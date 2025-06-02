using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;
using SimpleSchool.Models;
using SimpleSchool.Viewmodels;
using SimpleSchool.Viewmodels.Opleiding;

namespace SimpleSchool.Controllers
{
    [Authorize]
    public class OpleidingenController : Controller
    {
        private readonly SimpleSchoolContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public OpleidingenController(SimpleSchoolContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Opleidingen
        [Authorize(Roles = "Leerling")]
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            var leerling = await _context.Leerling.FirstOrDefaultAsync(l => l.EMail == user.Email);
            if (leerling == null || leerling.StudentenkaartId == 0)
            {
                // Toon alleen studentenkaart-index of redirect naar studentenkaart aanmaken
                return RedirectToAction("Create", "StudentenKaarten");
            }
            return View(await _context.Opleiding.ToListAsync());
        }

        // GET: Opleidingen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleiding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return View(opleiding);
        }

        // GET: Opleidingen/Create
        [Authorize(Roles = "Leerkracht")]
        public IActionResult Create()
        {
            return View(new OpleidingCreateViewModel());
        }

        // POST: Opleidingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Duur,BeschikbarePlaatsen,Beschrijving")] OpleidingCreateViewModel opleidingViewModel)
        {
            if (!ModelState.IsValid)
            {
                
                return View(opleidingViewModel);
            }

            var opleiding = new Opleiding
            {
                Naam = opleidingViewModel.Naam,
                Duur = opleidingViewModel.Duur,
                BeschikbarePlaatsen = opleidingViewModel.BeschikbarePlaatsen,
                Beschrijving = opleidingViewModel.Beschrijving
            };
            _context.Opleiding.Add(opleiding);
            await _context.SaveChangesAsync();
            TempData["OpleidingAangemaakt"] = true;
            return RedirectToAction(nameof(Index));
        }

        // GET: Opleidingen/Edit/5
        [Authorize(Roles = "Leerkracht")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleiding.FindAsync(id);
            if (opleiding == null)
            {
                return NotFound();
            }

            var viewModel = new OpleidingEditViewModel
            {
                Id = opleiding.Id,
                Naam = opleiding.Naam,
                Duur = opleiding.Duur,
                BeschikbarePlaatsen = opleiding.BeschikbarePlaatsen,
                Beschrijving = opleiding.Beschrijving
            };

            return View(viewModel);
        }

        // POST: Opleidingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Duur,BeschikbarePlaatsen,Beschrijving")] OpleidingEditViewModel opleidingViewModel)
        {
            if (id != opleidingViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
               
                return View(opleidingViewModel);
            }

            var opleiding = await _context.Opleiding.FindAsync(id);
            if (opleiding == null)
            {
                return NotFound();
            }

            opleiding.Naam = opleidingViewModel.Naam;
            opleiding.Duur = opleidingViewModel.Duur;
            opleiding.BeschikbarePlaatsen = opleidingViewModel.BeschikbarePlaatsen;
            opleiding.Beschrijving = opleidingViewModel.Beschrijving;

            _context.Update(opleiding);
            await _context.SaveChangesAsync();
            TempData["OpleidingAangemaakt"] = true;
           
            return RedirectToAction(nameof(Index));
        }

        // GET: Opleidingen/Delete/5
        [Authorize(Roles = "Leerkracht")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleiding
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return View(opleiding);
        }

        // POST: Opleidingen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var opleiding = await _context.Opleiding.FindAsync(id);
            if (opleiding != null)
            {
                _context.Opleiding.Remove(opleiding);
                TempData["OpleidingDelete"] = true;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpleidingExists(int id)
        {
            return _context.Opleiding.Any(e => e.Id == id);
        }
    }
}

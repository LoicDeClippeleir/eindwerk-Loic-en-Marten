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
using SimpleSchool.Viewmodels.Leerling;

namespace SimpleSchool.Controllers
{
    [Authorize(Roles = "Leerkracht")]
    public class LeerlingenController : Controller
    {

        private readonly SimpleSchoolContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public LeerlingenController(SimpleSchoolContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        // GET: Leerlingen

        public async Task<IActionResult> Index()
        {
            var simpleSchoolContext = _context.Leerling.Include(l => l.Opleiding).Include(l => l.Studentenkaart);
            return View(await simpleSchoolContext.ToListAsync());
        }

        // GET: Leerlingen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerling = await _context.Leerling
                .Include(l => l.Opleiding)
                .Include(l => l.Studentenkaart)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerling == null)
            {
                return NotFound();
            }

            return View(leerling);
        }

        // GET: Leerlingen/Create
        public IActionResult Create()
        {
            ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Naam");
            ViewData["StudentenkaartId"] = new SelectList(
                _context.StudentenKaart.Where(sk => sk.Leerling == null), "Id", "Naam");
            return View(new LeerlingCreateViewModel());
        }

        // POST: Leerlingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,Email,Adres,StudentenKaartId,OpleidingId")] LeerlingCreateViewModel leerlingViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Naam", leerlingViewModel.OpleidingId);
                ViewData["StudentenkaartId"] = new SelectList(
                    _context.StudentenKaart.Where(sk => sk.Leerling == null), "Id", "Naam", leerlingViewModel.StudentenKaartId);
                TempData["LeerlingAangemaakt"] = false;
                return View(leerlingViewModel);
            }
            var leerling = new Leerling
            {
                Naam = leerlingViewModel.Naam,
                GeboorteDatum = leerlingViewModel.GeboorteDatum,
                EMail = leerlingViewModel.Email,
                Adres = leerlingViewModel.Adres,
                StudentenkaartId = leerlingViewModel.StudentenKaartId,
                OpleidingId = leerlingViewModel.OpleidingId
            };
            _context.Leerling.Add(leerling);
            TempData["LeerlingAangemaakt"] = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Leerlingen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerling = await _context.Leerling
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.Id == id);

            if (leerling == null)
            {
                return NotFound();
            }

            var viewModel = new LeerlingEditViewModel
            {
                Id = leerling.Id,
                Naam = leerling.Naam,
                GeboorteDatum = leerling.GeboorteDatum,
                EMail = leerling.EMail,
                Adres = leerling.Adres,
                StudentenkaartId = leerling.StudentenkaartId,
                OpleidingId = leerling.OpleidingId
            };

            ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Naam", viewModel.OpleidingId);
            ViewData["StudentenkaartId"] = new SelectList(
                _context.StudentenKaart
                    .Where(sk => sk.Leerling == null || sk.Id == viewModel.StudentenkaartId),
                "Id", "Naam", viewModel.StudentenkaartId);
            return View(viewModel);
        }

        // POST: Leerlingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,GeboorteDatum,EMail,Adres,StudentenkaartId,OpleidingId")] LeerlingEditViewModel leerlingViewModel)
        {
            if (id != leerlingViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Naam", leerlingViewModel.OpleidingId);
                ViewData["StudentenkaartId"] = new SelectList(
                    _context.StudentenKaart
                        .Where(sk => sk.Leerling == null || sk.Id == leerlingViewModel.StudentenkaartId),
                    "Id", "Naam", leerlingViewModel.StudentenkaartId);
                return View(leerlingViewModel);
            }

            var leerling = await _context.Leerling.FindAsync(id);
            if (leerling == null)
            {
                return NotFound();
            }

            leerling.Naam = leerlingViewModel.Naam;
            leerling.GeboorteDatum = leerlingViewModel.GeboorteDatum;
            leerling.EMail = leerlingViewModel.EMail;
            leerling.Adres = leerlingViewModel.Adres;
            leerling.StudentenkaartId = leerlingViewModel.StudentenkaartId;
            leerling.OpleidingId = leerlingViewModel.OpleidingId;

            _context.Update(leerling);
            await _context.SaveChangesAsync();
            TempData["LeerlingEdit"] = true;
           
            return RedirectToAction(nameof(Index));
        }

        // GET: Leerlingen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerling = await _context.Leerling
                .Include(l => l.Opleiding)
                .Include(l => l.Studentenkaart)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerling == null)
            {
                return NotFound();
            }

            return View(leerling);
        }

        // POST: Leerlingen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leerling = await _context.Leerling.FindAsync(id);
            if (leerling != null)
            {
                _context.Leerling.Remove(leerling);
                TempData["LeerlingDelete"] = true;
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Leerkracht")]
        public async Task<IActionResult> MijnLeerlingen()
        {
            var user = await _userManager.GetUserAsync(User);
            var leerkracht = await _context.Leerkracht
                .Include(l => l.Vakken)
                .FirstOrDefaultAsync(l => l.EMail == user.Email);

            var vakIds = leerkracht.Vakken.Select(v => v.Id).ToList();

            var leerlingen = await _context.Leerling
                .Where(l => l.Opleiding.Vakken.Any(v => vakIds.Contains(v.Id)))
                .ToListAsync();

            return View(leerlingen);
        }


        private bool LeerlingExists(int id)
        {
            return _context.Leerling.Any(e => e.Id == id);
        }
    }
}

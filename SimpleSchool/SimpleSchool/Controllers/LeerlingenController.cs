using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
        
        public LeerlingenController(SimpleSchoolContext context)
        {
            _context = context;
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
            ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Id");
            ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Id");
            return View(new LeerlingCreateViewModel());
        }

        // POST: Leerlingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,Email,Adres,StudentenkaartId,OpleidingId")] LeerlingCreateViewModel leerlingViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Naam", leerlingViewModel.OpleidingId);
                ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Naam", leerlingViewModel.StudentenKaartId);
                
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
            return View(leerling);
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
            ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Naam", viewModel.StudentenkaartId);
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
                ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Naam", leerlingViewModel.StudentenkaartId);
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
            return View(leerling);
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

        private bool LeerlingExists(int id)
        {
            return _context.Leerling.Any(e => e.Id == id);
        }
    }
}

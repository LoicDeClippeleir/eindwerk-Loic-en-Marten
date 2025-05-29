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
using SimpleSchool.Viewmodels.Vak;


namespace SimpleSchool.Controllers
{
    [Authorize]
    public class VakkenController : Controller
    {
        private readonly SimpleSchoolContext _context;

        public VakkenController(SimpleSchoolContext context)
        {
            _context = context;
        }

        // GET: Vakken
        public async Task<IActionResult> Index()
        {
            var simpleSchoolContext = _context.Vak.Include(v => v.Leerkracht);
            return View(await simpleSchoolContext.ToListAsync());
        }

        // GET: Vakken/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vak
                .Include(v => v.Leerkracht)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vak == null)
            {
                return NotFound();
            }

            return View(vak);
        }

        // GET: Vakken/Create
        [Authorize(Roles = "Leerkracht")]
        public IActionResult Create()
        {
            ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Id");
            ViewBag.Vaktypes = new SelectList(new[] { "Theorie", "Praktijk" });
            ViewBag.Leerkrachten = new SelectList(_context.Leerkrachten, "Id", "Naam");
            
            return View(new VakCreateViewModel());
        }

        // POST: Vakken/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Taal,AantalStudiePunten,Vaktype,LeerkrachtId")] VakCreateViewModel vakViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Naam", vakViewModel.LeerkrachtId);
                TempData["VakAangemaakt"] = false;
                return View(vakViewModel);
            }

            var vak = new Vak
            {
                Naam = vakViewModel.Naam,
                Taal = vakViewModel.Taal,
                AantalStudiePunten = vakViewModel.AantalStudiePunten,
                Vaktype = vakViewModel.Vaktype,
                LeerkrachtId = vakViewModel.LeerkrachtId
            };

            _context.Vak.Add(vak);
            await _context.SaveChangesAsync();
            TempData["VakAangemaakt"] = true;
            return RedirectToAction(nameof(Index));
        }

        // GET: Vakken/Edit/5
        [Authorize(Roles = "Leerkracht")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vak.FindAsync(id);
            if (vak == null)
            {
                return NotFound();
            }

            var viewModel = new VakEditViewModel
            {
                Id = vak.Id,
                Naam = vak.Naam,
                Taal = vak.Taal,
                AantalStudiePunten = vak.AantalStudiePunten,
                Vaktype = vak.Vaktype,
                LeerkrachtId = vak.LeerkrachtId
            };

            ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Naam", viewModel.LeerkrachtId);
            return View(viewModel);
        }

        // POST: Vakken/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Taal,AantalStudiePunten,Vaktype,LeerkrachtId")] VakEditViewModel vakViewModel)
        {
            if (id != vakViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Naam", vakViewModel.LeerkrachtId);
                return View(vakViewModel);
            }

            var vak = await _context.Vak.FindAsync(id);
            if (vak == null)
            {
                return NotFound();
            }

            vak.Naam = vakViewModel.Naam;
            vak.Taal = vakViewModel.Taal;
            vak.AantalStudiePunten = vakViewModel.AantalStudiePunten;
            vak.Vaktype = vakViewModel.Vaktype;
            vak.LeerkrachtId = vakViewModel.LeerkrachtId;

            _context.Update(vak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Vakken/Delete/5
        [Authorize(Roles = "Leerkracht")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vak = await _context.Vak
                .Include(v => v.Leerkracht)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vak == null)
            {
                return NotFound();
            }

            return View(vak);
        }

        // POST: Vakken/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vak = await _context.Vak.FindAsync(id);
            if (vak != null)
            {
                _context.Vak.Remove(vak);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VakExists(int id)
        {
            return _context.Vak.Any(e => e.Id == id);
        }
    }
}

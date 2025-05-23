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
        public IActionResult Create()
        {
            ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Id");
            return View(new VakC);
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
            return View(vak);
        }

        // GET: Vakken/Edit/5
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
            ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Id", vak.LeerkrachtId);
            return View(vak);
        }

        // POST: Vakken/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Taal,AantalStudiePunten,Vaktype,LeerkrachtId")] Vak vak)
        {
            if (id != vak.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VakExists(vak.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LeerkrachtId"] = new SelectList(_context.Leerkracht, "Id", "Id", vak.LeerkrachtId);
            return View(vak);
        }

        // GET: Vakken/Delete/5
        [Authorize(Roles = "Admin")]
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

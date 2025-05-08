using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleschoolApp.Data;
using SimpleschoolApp.Models;

namespace SimpleschoolApp.Controllers
{
    public class LeerlingenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeerlingenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Leerlingen
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Leerling.Include(l => l.StudentenKaart);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Leerlingen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerling = await _context.Leerling
                .Include(l => l.StudentenKaart)
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
            ViewData["StudentenKaartId"] = new SelectList(_context.Set<StudentenKaart>(), "Id", "Id");
            return View();
        }

        // POST: Leerlingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,EMail,Adres,StudentenKaartId")] Leerling leerling)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leerling);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentenKaartId"] = new SelectList(_context.Set<StudentenKaart>(), "Id", "Id", leerling.StudentenKaartId);
            return View(leerling);
        }

        // GET: Leerlingen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerling = await _context.Leerling.FindAsync(id);
            if (leerling == null)
            {
                return NotFound();
            }
            ViewData["StudentenKaartId"] = new SelectList(_context.Set<StudentenKaart>(), "Id", "Id", leerling.StudentenKaartId);
            return View(leerling);
        }

        // POST: Leerlingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,GeboorteDatum,EMail,Adres,StudentenKaartId")] Leerling leerling)
        {
            if (id != leerling.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leerling);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeerlingExists(leerling.Id))
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
            ViewData["StudentenKaartId"] = new SelectList(_context.Set<StudentenKaart>(), "Id", "Id", leerling.StudentenKaartId);
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
                .Include(l => l.StudentenKaart)
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

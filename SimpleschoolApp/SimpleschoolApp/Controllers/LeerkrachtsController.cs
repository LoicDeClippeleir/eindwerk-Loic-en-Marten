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
    public class LeerkrachtsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeerkrachtsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Leerkrachts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Leerkracht.Include(l => l.Vak);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Leerkrachts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkracht
                .Include(l => l.Vak)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerkracht == null)
            {
                return NotFound();
            }

            return View(leerkracht);
        }

        // GET: Leerkrachts/Create
        public IActionResult Create()
        {
            ViewData["VakId"] = new SelectList(_context.Set<Vak>(), "Id", "Id");
            return View();
        }

        // POST: Leerkrachts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,EMail,Adres,VakId")] Leerkracht leerkracht)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leerkracht);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["VakId"] = new SelectList(_context.Set<Vak>(), "Id", "Id", leerkracht.VakId);
            return View(leerkracht);
        }

        // GET: Leerkrachts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkracht.FindAsync(id);
            if (leerkracht == null)
            {
                return NotFound();
            }
            ViewData["VakId"] = new SelectList(_context.Set<Vak>(), "Id", "Id", leerkracht.VakId);
            return View(leerkracht);
        }

        // POST: Leerkrachts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,GeboorteDatum,EMail,Adres,VakId")] Leerkracht leerkracht)
        {
            if (id != leerkracht.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(leerkracht);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeerkrachtExists(leerkracht.Id))
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
            ViewData["VakId"] = new SelectList(_context.Set<Vak>(), "Id", "Id", leerkracht.VakId);
            return View(leerkracht);
        }

        // GET: Leerkrachts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkracht
                .Include(l => l.Vak)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerkracht == null)
            {
                return NotFound();
            }

            return View(leerkracht);
        }

        // POST: Leerkrachts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var leerkracht = await _context.Leerkracht.FindAsync(id);
            if (leerkracht != null)
            {
                _context.Leerkracht.Remove(leerkracht);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeerkrachtExists(int id)
        {
            return _context.Leerkracht.Any(e => e.Id == id);
        }
    }
}

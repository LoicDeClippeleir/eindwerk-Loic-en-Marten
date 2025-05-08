using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;
using SimpleschoolApp.Models;

namespace SimpleSchool.Controllers
{
    public class LeerkrachtenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LeerkrachtenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Leerkrachten
        public async Task<IActionResult> Index()
        {
            return View(await _context.Leerkracht.ToListAsync());
        }

        // GET: Leerkrachten/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkracht
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerkracht == null)
            {
                return NotFound();
            }

            return View(leerkracht);
        }

        // GET: Leerkrachten/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Leerkrachten/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,EMail,Adres")] Leerkracht leerkracht)
        {
            if (ModelState.IsValid)
            {
                _context.Add(leerkracht);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(leerkracht);
        }

        // GET: Leerkrachten/Edit/5
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
            return View(leerkracht);
        }

        // POST: Leerkrachten/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,GeboorteDatum,EMail,Adres")] Leerkracht leerkracht)
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
            return View(leerkracht);
        }

        // GET: Leerkrachten/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkracht
                .FirstOrDefaultAsync(m => m.Id == id);
            if (leerkracht == null)
            {
                return NotFound();
            }

            return View(leerkracht);
        }

        // POST: Leerkrachten/Delete/5
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

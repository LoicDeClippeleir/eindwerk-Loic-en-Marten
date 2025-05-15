using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;
using SimpleSchool.Viewmodels;
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
            return View(await _context.Leerkrachten.ToListAsync());
        }

        // GET: Leerkrachten/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkrachten
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
        public async Task<IActionResult> Create([Bind("Id,Naam,GeboorteDatum,EMail,Adres")] LeerkrachtCreateViewModel leerkracht)
        {
            if (!ModelState.IsValid)
            {
                // Bekijk de fouten in ModelState
                var errors = ModelState.Values.SelectMany(v => v.Errors).Select(e => e.ErrorMessage);
                return View(leerkracht); // Toon het formulier opnieuw met validatiefouten
            }
            // Map het model naar de database-entiteit en sla op
            var leerkrachtViewmodel = new Leerkracht
            {
                Naam = leerkracht.Naam,
                GeboorteDatum = leerkracht.GeboorteDatum,
                EMail = leerkracht.EMail,
                Adres = leerkracht.Adres,
                Vakken = leerkracht.VakkenIds.Select(id => new Vak { Id = id }).ToList()
            };
            _context.Leerkrachten.Add(leerkrachtViewmodel);
            _context.SaveChanges();
            return View(leerkracht);
        }

        // GET: Leerkrachten/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var leerkracht = await _context.Leerkrachten.FindAsync(id);
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

            var leerkracht = await _context.Leerkrachten
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
            var leerkracht = await _context.Leerkrachten.FindAsync(id);
            if (leerkracht != null)
            {
                _context.Leerkrachten.Remove(leerkracht);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LeerkrachtExists(int id)
        {
            return _context.Leerkrachten.Any(e => e.Id == id);
        }
    }
}

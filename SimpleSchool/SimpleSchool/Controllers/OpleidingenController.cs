using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleSchool.Data;
using Simpleschool.Models;

namespace SimpleSchool.Controllers
{
    public class OpleidingenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OpleidingenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Opleidingen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Opleidingen.ToListAsync());
        }

        // GET: Opleidingen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen
                .FirstOrDefaultAsync(m => m.Id == id);
            if (opleiding == null)
            {
                return NotFound();
            }

            return View(opleiding);
        }

        // GET: Opleidingen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Opleidingen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Duur,BeschikbarePlaatsen,Beschrijving")] Opleiding opleiding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opleiding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opleiding);
        }

        // GET: Opleidingen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen.FindAsync(id);
            if (opleiding == null)
            {
                return NotFound();
            }
            return View(opleiding);
        }

        // POST: Opleidingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Duur,BeschikbarePlaatsen,Beschrijving")] Opleiding opleiding)
        {
            if (id != opleiding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opleiding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpleidingExists(opleiding.Id))
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
            return View(opleiding);
        }

        // GET: Opleidingen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opleiding = await _context.Opleidingen
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
            var opleiding = await _context.Opleidingen.FindAsync(id);
            if (opleiding != null)
            {
                _context.Opleidingen.Remove(opleiding);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpleidingExists(int id)
        {
            return _context.Opleidingen.Any(e => e.Id == id);
        }
    }
}

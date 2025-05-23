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

namespace SimpleSchool.Controllers
{
    [Authorize]
    public class OpleidingenController : Controller
    {
        private readonly SimpleSchoolContext _context;

        public OpleidingenController(SimpleSchoolContext context)
        {
            _context = context;
        }

        // GET: Opleidingen
        
        public async Task<IActionResult> Index()
        {
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
                TempData["OpleidingAangemaakt"] = true;
                return RedirectToAction(nameof(Index));
            } else
            {
                TempData["OpleidingAangemaakt"] = false;
            }
            return View(opleiding);
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

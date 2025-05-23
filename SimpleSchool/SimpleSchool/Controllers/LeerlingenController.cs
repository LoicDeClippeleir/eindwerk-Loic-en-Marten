﻿using System;
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
    [Authorize]
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
            ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Id", leerling.OpleidingId);
            ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Id", leerling.StudentenkaartId);
            return View(leerling);
        }

        // POST: Leerlingen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,GeboorteDatum,EMail,Adres,StudentenkaartId,OpleidingId")] Leerling leerling)
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
            ViewData["OpleidingId"] = new SelectList(_context.Opleiding, "Id", "Id", leerling.OpleidingId);
            ViewData["StudentenkaartId"] = new SelectList(_context.StudentenKaart, "Id", "Id", leerling.StudentenkaartId);
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

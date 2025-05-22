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
    public class StudentenKaartenController : Controller
    {
        private readonly SimpleSchoolContext _context;
        

        public StudentenKaartenController(SimpleSchoolContext context)
        {
            _context = context;
        }

        // GET: StudentenKaarten
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentenKaart.ToListAsync());
        }

        // GET: StudentenKaarten/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentenKaart = await _context.StudentenKaart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentenKaart == null)
            {
                return NotFound();
            }

            return View(studentenKaart);
        }

        // GET: StudentenKaarten/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentenKaarten/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Klas,School")] StudentenKaart studentenKaart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentenKaart);
                await _context.SaveChangesAsync();
                TempData["StudentenKaartAangemaakt"] = true;
                return RedirectToAction(nameof(Index));
            }
            return View(studentenKaart);
        }

        // GET: StudentenKaarten/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentenKaart = await _context.StudentenKaart.FindAsync(id);
            if (studentenKaart == null)
            {
                return NotFound();
            }
            return View(studentenKaart);
        }

        // POST: StudentenKaarten/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Klas,School")] StudentenKaart studentenKaart)
        {
            if (id != studentenKaart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentenKaart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentenKaartExists(studentenKaart.Id))
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
            return View(studentenKaart);
        }

        // GET: StudentenKaarten/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentenKaart = await _context.StudentenKaart
                .FirstOrDefaultAsync(m => m.Id == id);
            if (studentenKaart == null)
            {
                return NotFound();
            }

            return View(studentenKaart);
        }

        // POST: StudentenKaarten/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentenKaart = await _context.StudentenKaart.FindAsync(id);
            if (studentenKaart != null)
            {
                _context.StudentenKaart.Remove(studentenKaart);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentenKaartExists(int id)
        {
            return _context.StudentenKaart.Any(e => e.Id == id);
        }
    }
}

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
using SimpleSchool.Viewmodels.Studentenkaart;

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
        [Authorize(Roles = "Leerkracht")]
        public IActionResult Create()
        {
            return View(new StudentenkaartCreateViewModel());
        }

        // POST: StudentenKaarten/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam,Klas,School")] StudentenkaartCreateViewModel studentenKaartViewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData["StudentenKaartAangemaakt"] = false;
                return View(studentenKaartViewModel);
            }

            var studentenKaart = new StudentenKaart
            {
                Naam = studentenKaartViewModel.Naam,
                Klas = studentenKaartViewModel.Klas,
                School = studentenKaartViewModel.School
            };

            _context.StudentenKaart.Add(studentenKaart);
            await _context.SaveChangesAsync();
            TempData["StudentenKaartAangemaakt"] = true;
            return View(studentenKaart);
        }

        // GET: StudentenKaarten/Edit/5
        [Authorize(Roles = "Leerkracht ")]
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

            var viewModel = new StudentenkaartEditViewModel
            {
                Id = studentenKaart.Id,
                Naam = studentenKaart.Naam,
                Klas = studentenKaart.Klas,
                School = studentenKaart.School
            };

            return View(viewModel);
        }

        // POST: StudentenKaarten/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam,Klas,School")] StudentenkaartEditViewModel studentenKaartViewModel)
        {
            if (id != studentenKaartViewModel.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(studentenKaartViewModel);
            }

            var studentenKaart = await _context.StudentenKaart.FindAsync(id);
            if (studentenKaart == null)
            {
                return NotFound();
            }

            studentenKaart.Naam = studentenKaartViewModel.Naam;
            studentenKaart.Klas = studentenKaartViewModel.Klas;
            studentenKaart.School = studentenKaartViewModel.School;

            _context.Update(studentenKaart);
            await _context.SaveChangesAsync();
            return View(studentenKaart);
        }

        // GET: StudentenKaarten/Delete/5
        [Authorize(Roles = "Leerkracht")]
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

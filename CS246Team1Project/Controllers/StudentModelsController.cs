using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CS246Team1Project.Data;
using CS246Team1Project.Models;

namespace CS246Team1Project.Controllers
{
    public class StudentModelsController : Controller
    {
        private readonly CS246Team1ProjectContext _context;

        public StudentModelsController(CS246Team1ProjectContext context)
        {
            _context = context;
        }

        // GET: StudentModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentModel.ToListAsync());
        }

        // GET: StudentModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel
                .FirstOrDefaultAsync(m => m.LNumber == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // GET: StudentModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LNumber,FirstName,LastName,PhoneNumber,PersonalEmail,LaneEmail,CohortYear,Notes")] StudentModel studentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentModel);
        }

        // GET: StudentModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel.FindAsync(id);
            if (studentModel == null)
            {
                return NotFound();
            }
            return View(studentModel);
        }

        // POST: StudentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LNumber,FirstName,LastName,PhoneNumber,PersonalEmail,LaneEmail,CohortYear,Notes")] StudentModel studentModel)
        {
            if (id != studentModel.LNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentModelExists(studentModel.LNumber))
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
            return View(studentModel);
        }

        // GET: StudentModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentModel = await _context.StudentModel
                .FirstOrDefaultAsync(m => m.LNumber == id);
            if (studentModel == null)
            {
                return NotFound();
            }

            return View(studentModel);
        }

        // POST: StudentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentModel = await _context.StudentModel.FindAsync(id);
            if (studentModel != null)
            {
                _context.StudentModel.Remove(studentModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentModelExists(int id)
        {
            return _context.StudentModel.Any(e => e.LNumber == id);
        }
    }
}

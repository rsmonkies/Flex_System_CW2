using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;
using Microsoft.AspNetCore.Authorization;

namespace ITS_System.Areas.Admin.Views
{
    [Authorize(Roles = "Admin")]
    public class EqupimentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EqupimentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Equpiments
        public async Task<IActionResult> Index()
        {
              return _context.Equpiments != null ? 
                          View(await _context.Equpiments.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Equpiments'  is null.");
        }

        // GET: Admin/Equpiments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Equpiments == null)
            {
                return NotFound();
            }

            var equpiment = await _context.Equpiments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equpiment == null)
            {
                return NotFound();
            }

            return View(equpiment);
        }

        // GET: Admin/Equpiments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Equpiments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Equipment equpiment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equpiment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equpiment);
        }

        // GET: Admin/Equpiments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Equpiments == null)
            {
                return NotFound();
            }

            var equpiment = await _context.Equpiments.FindAsync(id);
            if (equpiment == null)
            {
                return NotFound();
            }
            return View(equpiment);
        }

        // POST: Admin/Equpiments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Equipment equpiment)
        {
            if (id != equpiment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equpiment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EqupimentExists(equpiment.Id))
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
            return View(equpiment);
        }

        // GET: Admin/Equpiments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Equpiments == null)
            {
                return NotFound();
            }

            var equpiment = await _context.Equpiments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equpiment == null)
            {
                return NotFound();
            }

            return View(equpiment);
        }

        // POST: Admin/Equpiments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Equpiments == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Equpiments'  is null.");
            }
            var equpiment = await _context.Equpiments.FindAsync(id);
            if (equpiment != null)
            {
                _context.Equpiments.Remove(equpiment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EqupimentExists(int id)
        {
          return (_context.Equpiments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

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
    public class EquipmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Equpiments
        public async Task<IActionResult> Index()
        {
              return _context.Equipments != null ? 
                          View(await _context.Equipments.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Equpiments'  is null.");
        }

        // GET: Admin/Equpiments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Equipments == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
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
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Equipment equipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(equipment);
        }

        // GET: Admin/Equpiments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Equipments == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments.FindAsync(id);
            if (equipment == null)
            {
                return NotFound();
            }
            return View(equipment);
        }

        // POST: Admin/Equpiments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Equipment equipment)
        {
            if (id != equipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EqupimentExists(equipment.Id))
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
            return View(equipment);
        }

        // GET: Admin/Equpiments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Equipments == null)
            {
                return NotFound();
            }

            var equipment = await _context.Equipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipment == null)
            {
                return NotFound();
            }

            return View(equipment);
        }

        // POST: Admin/Equpiments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Equipments == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Equpiments'  is null.");
            }
            var equipment = await _context.Equipments.FindAsync(id);
            if (equipment != null)
            {
                _context.Equipments.Remove(equipment);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EqupimentExists(int id)
        {
          return (_context.Equipments?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

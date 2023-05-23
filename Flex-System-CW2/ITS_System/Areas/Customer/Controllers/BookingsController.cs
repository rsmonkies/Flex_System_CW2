using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;

namespace ITS_System.Areas.Customer.Views
{
    [Area("Customer")]
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

       

        // GET: Customer/Bookings
      

        // GET: Customer/Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // GET: Customer/Bookings/Create
        public async  Task<IActionResult> Index(string search)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(search))
            {
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(search) || s.ClassName.ToLower().Contains(search.ToLower()));
            }

            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.ClassName).ToListAsync());
        }

     /*   public async Task<IActionResult> Create(string search)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(search))
            {
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(search) || s.ClassName.ToLower().Contains(search.ToLower()));
            }

            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.ClassName).ToListAsync());
        }*/

        // POST: Customer/Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      /*  public async Task<IActionResult> Create([Bind("ClassName,Id,ClassId,TimeStamp,Status")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassName"] = new SelectList(_context.Schedule, "Id", "ClassName", booking.ClassId);
            ViewData["DateTime"] = new SelectList(_context.Schedule, "Id", "DateTime", booking.ClassId);
            ViewData["Status"] = new SelectList(_context.Schedule, "Id", "Status", booking.ClassId);

            return View(booking);
        }*/

        // GET: Customer/Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewData["ClassName"] = new SelectList(_context.Schedule, "Id", "ClassName", booking.ClassId);
            ViewData["DateTime"] = new SelectList(_context.Schedule, "Id", "DateTime", booking.ClassId);
            ViewData["Status"] = new SelectList(_context.Schedule, "Id", "Status", booking.ClassId);

            return View(booking);
        }

        // POST: Customer/Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassName,Id,ClassId,TimeStamp,Status")] Booking booking)
        {
            if (id != booking.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.Id))
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
            ViewData["ClassName"] = new SelectList(_context.Schedule, "Id", "ClassName", booking.ClassId);
            ViewData["DateTime"] = new SelectList(_context.Schedule, "Id", "DateTime", booking.ClassId);
            ViewData["Status"] = new SelectList(_context.Schedule, "Id", "Status", booking.ClassId);

            return View(booking);
        }

        // GET: Customer/Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        // POST: Customer/Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bookings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Bookings'  is null.");
            }
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookingExists(int id)
        {
          return (_context.Bookings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

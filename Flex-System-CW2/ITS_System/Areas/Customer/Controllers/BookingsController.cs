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

        public async Task<IActionResult> Index(string search)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(search))
            {
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(search) || s.ClassName.ToLower().Contains(search.ToLower()));
            }


            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.ClassName).ToListAsync());

           
        }

        public async Task<IActionResult> Create(int Id)
        {
            var chosenClass = await _context.Schedule.FindAsync(Id);
            var booking = new Booking()
            {
                ClassId = chosenClass.Id,

                TimeStamp = chosenClass.DateTime,

               Status = (Enums.BookingStatus)chosenClass.Status

            };

            return View();
        }


            public IActionResult ViewBookings()
            {
                var applicationDbContext = _context.Schedule.ToList();
                return View(applicationDbContext);
            }
        }
    }



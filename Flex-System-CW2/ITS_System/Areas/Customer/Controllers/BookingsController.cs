using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;
using Microsoft.AspNetCore.Identity;

namespace ITS_System.Areas.Customer.Views
{
    [Area("Customer")]
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string search)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(search))
            {
                //Using the search bar in the index for this controller, this allows the user to search for class by intructors email or the class name. This is also not case sensitive.
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(search) || s.ClassName.ToLower().Contains(search.ToLower()));
            }


            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.ClassName).ToListAsync());

           
        }

        public async Task<IActionResult> Booking(int Id)
        {
            //Grabs the users name/username
           var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);
           if(currentUser == null)
            {
                return NotFound();
            }
           
           Booking book = new Booking();
            book.ClassId = Id;
            book.AttendeeId = currentUser.Id;
            book.TimeStamp = DateTime.Now;
            book.Status = Enums.BookingStatus.Active;
            book.Attendee = currentUser;
            
            var currentClass = await _context.Schedule.Include(s => s.Attendees).Where(s => s.Id == Id).FirstOrDefaultAsync();

            if(currentClass == null)
            {
                return NotFound();
            }
            //This bool ensures that is the current user already has an attendee id for this class then they can not double book it 
            bool doublebook = currentClass.Attendees.Any(a => a.AttendeeId == currentUser.Id);
            if (doublebook)
            {
                return RedirectToAction("Index", "Booking");
            }
            book.Class = currentClass;
            currentClass.Attendees.Add(book); //Adds class to book
            _context.Schedule.Update(currentClass);//Updates the current class
            await _context.SaveChangesAsync();


            return RedirectToAction("Index", "Booking");
        }


            public IActionResult ViewBookings()
            {
                //Grabs items from the database and creates a list of context for viewing
                var applicationDbContext = _context.Schedule.ToList();
                return View(applicationDbContext);
            }
        }

   


   
}
    



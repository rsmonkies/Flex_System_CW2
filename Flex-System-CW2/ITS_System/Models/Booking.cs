using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ITS_System.Models.Enums;

namespace ITS_System.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ClassId")]
        public ClassSchedule Class { get; set; }

        [Required]
        public int ClassId { get; set; }

        
        [ForeignKey("AttendeeId")]
        public IdentityUser Attendee { get; set; }

        [Required]
        public string AttendeeId { get; set; }


        [Required]
        public DateTime TimeStamp { get; set; }

        [Required]
        public BookingStatus Status { get; set; }
    }
}

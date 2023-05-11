using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static ITS_System.Models.Enums;

namespace ITS_System.Models
{
    public class ClassSchedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        public IdentityUser Instructor { get; set; }

        [Required]
        public int MaxNumbersOfBooking { get; set; }
        
        [Required]
        public Room Room { get; set; }

        [Required]
        [ForeignKey("RoomId")]
        public int RoomId { get; set; }

        public ClassStatus Status { get; set; }

        public virtual List<WaitingListEntry> WaitingList { get; set; }
        public virtual List<Booking> Attendees { get; set; }
        public virtual List<Equpiment> Equpiments { get; set; }
    }
}

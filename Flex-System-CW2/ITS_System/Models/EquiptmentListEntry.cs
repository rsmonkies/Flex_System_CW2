using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ITS_System.Models
{
    public class EquiptmentListEntry
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public Equpiment Equiptment { get; set; }

        [Required]

        public DateTime AddedOn { get; set; }
    }
}

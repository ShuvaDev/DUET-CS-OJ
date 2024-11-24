using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DUET_CS_OJ.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DutchTreat.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5)]
        public int Name { get; set; }
        [Required]
        [EmailAddress]
        public int Email { get; set; }
        [Required]
        public int Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "Too Long")]
        public int Message { get; set; }
    }
}

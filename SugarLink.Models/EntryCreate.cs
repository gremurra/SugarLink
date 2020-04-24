using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Models
{
    public class EntryCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(3, ErrorMessage = "Please enter only 3 characters.")]
        public int BloodSugarReading { get; set; }
    }
}

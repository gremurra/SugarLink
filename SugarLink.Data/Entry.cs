using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Data
{
   public class Entry
    {
        public int EntryId { get; set; }
         
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        public int BloodSugarReading { get; set; }
        [Required]
        public DateTimeOffset EntryDate { get; set; }
        [Key]
        [ForeignKey(nameof(Patient))]
        public Guid PatientId { get; set; }

        public virtual Patient Patient { get; set; }
    }
}

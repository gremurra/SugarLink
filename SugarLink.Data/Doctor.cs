using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Data
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Display(Name = "Patient Notes")]
        public string Notes { get; set; }
        
        [Required]
        public string LastName { get; set; }
        
        [Display(Name = "Patient Prescriptions")]
        public string Prescriptions { get; set; }

        
    }
}

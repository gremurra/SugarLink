using SugarLink.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Models
{
    public class PatientCreate
    {
        [Key]
        public Guid PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public GenderType TypeOfGender { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Weight { get; set; }
        [Required]
        public string Medications { get; set; }
        [Required]
        public DiabetesType TypeOfDiabetes { get; set; }
        //[Required]
        //public Doctor DoctorId { get; set; }
    }
}

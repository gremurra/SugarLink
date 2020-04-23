using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Data
{
    public enum GenderType { male =1, female, other }
    public enum DiabetesType { type1 =1, type2 }
   public class Patient
    {
        [Key]
        public Guid PatientId { get; set; }
        //public string FirstName { get; set; }         Add to ApplicationUser class??
        //public string LastName { get; set; }          ^^^^^^^^^^^^^^^^^^^^^^^^^^^
        public DateTime DateOfBirth { get; set; }

        [Required]
        public GenderType TypeOfGender { get; set; }

        [Required]
        [DisplayName("Height in Inches")]
        public int Height { get; set; }
        
        [Required]
        [DisplayName("Weight in Pounds")]
        public int Weight { get; set; }
        
        [Required]
        public string? Medications { get; set; }
        
        [Required]
        public DiabetesType TypeOfDiabetes { get; set; }
    }
}

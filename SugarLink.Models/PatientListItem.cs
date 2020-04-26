using SugarLink.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Models
{
    public class PatientListItem
    {
        [Key]
        public Guid PatientId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public GenderType TypeOfGender { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}

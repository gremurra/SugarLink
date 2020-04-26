using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Models
{
    public class DoctorListItem
    {
        [Required]
        public string LastName { get; set; }
    }
}

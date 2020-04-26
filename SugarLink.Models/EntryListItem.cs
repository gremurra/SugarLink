using SugarLink.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Models
{
    public class EntryListItem
    {
        public int EntryId { get; set; }
        
        [DisplayName("Date of entry")]
        public DateTimeOffset EntryDate { get; set; }
        
        [DisplayName("Blood sugar level")]
        public int BloodSugarReading { get; set; }
        public Guid PatientId { get; set; }
    }
}

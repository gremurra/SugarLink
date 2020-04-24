using SugarLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SugarLink

namespace SugarLink.Services
{
    public class EntryService
    {
        private readonly Guid _patientId;
        public EntryService(Guid patientId)
        {
            _patientId = patientId;
        }

        // CreateEntry()
        public bool CreateEntry(EntryCreate model)
        {
            var entity =
                new Entry() { };

        }
        // GetEntry()
        // GetEntryById()
        // EditEntry()
        // DeleteEntry()
    }
}

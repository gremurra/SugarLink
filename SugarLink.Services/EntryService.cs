using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SugarLink.Data;
using SugarLink.Models;


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
                new Entry()
                {
                    PatientId = _patientId,
                    EntryDate = DateTimeOffset.Now,
                    BloodSugarReading = model.BloodSugarReading
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Entries.Add(entity);
                return ctx.SaveChanges() == 1;
            }

        }
        // GetEntry()
        public IEnumerable<EntryListItem> GetEntries()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Entries
                        .Where(e => e.PatientId == _patientId)
                        .Select(
                            e =>
                                new EntryListItem
                                {
                                    EntryId = e.EntryId,
                                    EntryDate = e.EntryDate,
                                    BloodSugarReading = e.BloodSugarReading
                                }
                        );
                return query.ToArray();
            }
        }
        // GetEntryById()
        // EditEntry()
        // DeleteEntry()
    }
}

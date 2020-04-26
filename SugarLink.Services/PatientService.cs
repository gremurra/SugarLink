using SugarLink.Data;
using SugarLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Services
{
    public class PatientService
    {
        private readonly Guid _patientId;

        public PatientService(Guid patientId)
        {
            _patientId = patientId;
        }

        public bool CreatePatient(PatientCreate model)
        {
            var entity =
                new Patient()
                {
                    PatientId = _patientId,
                    TypeOfGender = model.TypeOfGender,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    DateOfBirth = model.DateOfBirth,
                    Height = model.Height,
                    Weight = model.Weight,
                    Medications = model.Medications,
                    TypeOfDiabetes = model.TypeOfDiabetes
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Patients.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<PatientListItem> GetPatients()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Patients
                    .Where(e => e.PatientId == _patientId)
                    .Select(
                        e =>
                        new PatientListItem
                        {
                            PatientId = e.PatientId,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            TypeOfGender = e.TypeOfGender,
                            DateOfBirth = e.DateOfBirth
                        }
                        );

                return query.ToArray();
            }
        }
    }
}

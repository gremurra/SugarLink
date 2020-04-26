using SugarLink.Data;
using SugarLink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLink.Services
{
    public class DoctorService
    {
        private readonly Guid _doctorId;

        public DoctorService(Guid doctorId)
        {
            _doctorId = doctorId;
        }

        public bool CreateDoctor(DoctorCreate dmodel)
        {
            var entity =
                new Doctor()
                {
                    LastName = dmodel.LastName
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Doctors.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}

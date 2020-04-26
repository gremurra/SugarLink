using Microsoft.AspNet.Identity;
using SugarLink.Models;
using SugarLink.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SugarLink.API.Controllers
{
    [Authorize]
    public class PatientController : ApiController
    {
        private PatientService CreatePatientService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var patientService = new PatientService(userId);
            return patientService;
        }

        public IHttpActionResult Get()
        {
            PatientService patientService = CreatePatientService();
            var patients = patientService.GetPatients();
            return Ok(patients);
        }

        public IHttpActionResult Post(PatientCreate patient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreatePatientService();

            if (!service.CreatePatient(patient))
                return InternalServerError();

            return Ok();
        }
    }
}

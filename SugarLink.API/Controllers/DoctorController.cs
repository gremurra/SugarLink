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
    public class DoctorController : ApiController
    {
        private DoctorService CreateDoctorService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var doctorService = new DoctorService(userId);
            return doctorService;
        }

        public IHttpActionResult Post(DoctorCreate doctor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateDoctorService();

            if (!service.CreateDoctor(doctor))
                return InternalServerError();

            return Ok();
        }
    }
}

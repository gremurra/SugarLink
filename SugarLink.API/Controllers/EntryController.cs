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
    public class EntryController : ApiController
    {
        public IHttpActionResult Get()
        {
            EntryService entryService = CreateEntryService();
            var entries = entryService.GetEntries();
            return Ok(entries);
        }

        public IHttpActionResult Post(EntryCreate entry)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateEntryService();

            if (!service.CreateEntry(entry))
                return InternalServerError();
            return Ok();
        }
        private EntryService CreateEntryService()
        {
            var patientId = Guid.Parse(User.Identity.GetUserId());
            var entryService = new EntryService(patientId);
            return entryService;
        }
    }
}

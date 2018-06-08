using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConferenceApp.WebAPI.DataAccess;
using ConferenceApp.WebAPI.Models.Entities;
using AutoMapper;

namespace ConferenceApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class SessionsController : Controller
    {
        private readonly ISessionRepository _sessionRepository;

        public SessionsController(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        [HttpGet]
        // GET: api/sessions/
        public async Task<IActionResult> GetAll()
        {
            var sessions = await _sessionRepository.All();
            return Ok(sessions);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var session = await _sessionRepository.Get(id);
            return Ok(session);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ConferenceSession session)
        {
            var saved = await _sessionRepository.Insert(session);
            return Ok(saved);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]ConferenceSession updated)
        {
            ConferenceSession session = await _sessionRepository.Get(id);

            // Map the database session object with the updated properties
            Mapper.Initialize(cfg => cfg.CreateMap<ConferenceSession, ConferenceSession>());
            Mapper.Map(updated, session);

            await _sessionRepository.Update(session);
            return Ok();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ConferenceSession session = await _sessionRepository.Get(id);
            await _sessionRepository.Delete(id);
            return Ok();
        }
    }
}
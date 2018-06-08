using ConferenceApp.WebAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public class ConferenceSessionRepository : ISessionRepository
    {
        private readonly ConferenceAppContext _context;

        public ConferenceSessionRepository(ConferenceAppContext context)
        {
            _context = context;
        }

        public async Task<List<ConferenceSession>> All()
        {
            return await _context.Sessions.ToListAsync();
        }

        public async Task<ConferenceSession> Get(int id)
        {
            return await _context.Sessions.FindAsync(id);
        }

        public async Task<ConferenceSession> Insert(ConferenceSession session)
        {
            _context.Sessions.Add(session);
            try
            {
                await _context.SaveChangesAsync();
                return session;
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task Update(ConferenceSession session)
        {
            _context.Sessions.Update(session);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public async Task Delete(int id)
        {
            var session = await _context.Sessions.FindAsync(id);
            _context.Sessions.Remove(session);
            await _context.SaveChangesAsync();
        }
    }
}
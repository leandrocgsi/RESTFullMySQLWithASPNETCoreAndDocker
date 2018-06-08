using ConferenceApp.WebAPI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public interface ISessionRepository
    {
        Task<List<ConferenceSession>> All();
        Task<ConferenceSession> Get(int id);
        Task<ConferenceSession> Insert(ConferenceSession session);
        Task Update(ConferenceSession session);
        Task Delete(int id);
    }
}

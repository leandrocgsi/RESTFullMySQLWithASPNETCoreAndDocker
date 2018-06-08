using ConferenceApp.WebAPI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceApp.WebAPI.DataAccess
{
    public class ConferenceAppContext : DbContext
    {
        public ConferenceAppContext(DbContextOptions option) : base(option) { }

        public DbSet<ConferenceSession> Sessions { get; set; }
    }
}

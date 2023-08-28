using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;

namespace Server.HoroscopesDB
{
    internal class HoroscopesDbContext : DbContext
    {
        public DbSet<ZodiacSign> ZodiacSigns { get; set; }
        public DbSet<Prediction> Predictions { get; set; }

        public HoroscopesDbContext() : base("name=ConnectToHoroscopesDb")
        {

        }
    }
}

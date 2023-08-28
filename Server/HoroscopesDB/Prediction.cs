using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.HoroscopesDB
{
    internal class Prediction
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public ICollection<ZodiacSign> ZodiacSigns { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.HoroscopesDB
{
    internal class Prediction
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(500)]
        [Required]

        public string Content { get; set; }

        public ICollection<ZodiacSign> ZodiacSigns { get; set; }
    }
}

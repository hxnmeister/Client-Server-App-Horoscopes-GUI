using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.HoroscopesDB
{
    internal class ZodiacSign
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public ICollection<Prediction> Predictions { get; set; }
    }
}

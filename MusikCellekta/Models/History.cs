using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Models
{
    public class History
    {
        public int ID { get; set; }
        public int SongID { get; set; }
        public DateTime Created { get; set; }

        public Song Song { get; set; }
    }
}

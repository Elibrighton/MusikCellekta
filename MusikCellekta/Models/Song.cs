using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Models
{
    public class Song
    {
        public int ID { get; set; }
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Bpm { get; set; }
        public string Key { get; set; }
        public int Intensity { get; set; }
        public int Year { get; set; }
        public string Disc { get; set; }
        public int Track { get; set; }
        public string Genre { get; set; }
    }
}

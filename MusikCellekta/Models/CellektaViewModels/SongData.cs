using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Models.CellektaViewModels
{
    public class SongData
    {
        public Song Song { get; set; }
        public bool IsKeyMatch { get; set; }
        public bool IsIntensityMatch { get; set; }
        public bool IsYearMatch { get; set; }
        public bool IsGenreMatch { get; set; }
        public int MatchedCount { get; set; }
    }
}

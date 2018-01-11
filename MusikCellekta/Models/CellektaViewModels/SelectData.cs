using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Models.CellektaViewModels
{
    public class SelectData
    {
        public Song SongSelection { get; set; }
        public List<SongData> MatchingSongs { get; set; }
    }
}

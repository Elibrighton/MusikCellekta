using MusikCellekta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusikCellekta.Data
{
    public class DbInitializer
    {
        public static void Initialize(CellektaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Songs.Any())
            {
                return;   // DB has been seeded
            }

            var songs = new Song[]
            {
                new Song{Artist = "Snap!", Title = "The Power (LQ)", Bpm = 109, Key = "10A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 1},
                new Song{Artist = "C+C Music Factory", Title = "Gonna Make You Sweat (Everybody Dance Now) (LQ)", Bpm = 115, Key = "3A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 2}
            };

            foreach (Song s in songs)
            {
                context.Songs.Add(s);
            }

            context.SaveChanges();
        }
    }
}

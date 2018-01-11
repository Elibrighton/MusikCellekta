using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusikCellekta.Data;
using MusikCellekta.Models;
using MusikCellekta.Models.CellektaViewModels;

namespace MusikCellekta.Controllers
{
    public class SongsController : Controller
    {
        private readonly CellektaContext _context;

        public SongsController(CellektaContext context)
        {
            _context = context;
        }

        // GET: Songs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Songs.ToListAsync());
        }

        // GET: Songs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // GET: Songs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Songs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Artist,Title,Bpm,Key,Intensity,Year,Disc,Track,Genre")] Song song)
        {
            if (ModelState.IsValid)
            {
                _context.Add(song);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(song);
        }

        // GET: Songs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs.SingleOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }
            return View(song);
        }

        // POST: Songs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Artist,Title,Bpm,Key,Intensity,Year,Disc,Track,Genre")] Song song)
        {
            if (id != song.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(song);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SongExists(song.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(song);
        }

        // GET: Songs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var song = await _context.Songs
                .SingleOrDefaultAsync(m => m.ID == id);
            if (song == null)
            {
                return NotFound();
            }

            return View(song);
        }

        // POST: Songs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var song = await _context.Songs.SingleOrDefaultAsync(m => m.ID == id);
            _context.Songs.Remove(song);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SongExists(int id)
        {
            return _context.Songs.Any(e => e.ID == id);
        }
        
        // GET: Songs/Select/5
        public async Task<IActionResult> Select(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var selectData = new SelectData();
            selectData.SongSelection = await _context.Songs.SingleOrDefaultAsync(m => m.ID == id);

            if (selectData.SongSelection == null)
            {
                return NotFound();
            }

            selectData.MatchingSongs = new List<SongData>();
            var songs = await _context.Songs.ToListAsync();

            foreach (var song in songs)
            {
                if (song.ID != selectData.SongSelection.ID)
                {
                    if (IsBpmInRange(song.Bpm, selectData.SongSelection.Bpm))
                    {
                        var songData = new SongData
                        {
                            ID = song.ID,
                            Artist = song.Artist,
                            Bpm = song.Bpm,
                            Disc = song.Disc,
                            Genre = song.Genre,
                            Intensity = song.Intensity,
                            Key = song.Key,
                            Title = song.Title,
                            Track = song.Track,
                            Year = song.Year
                        };

                        songData.IsGenreMatch = IsGenreMatch(song.Genre, selectData.SongSelection.Genre);
                        songData.IsYearMatch = IsYearMatch(song.Year, selectData.SongSelection.Year);
                        songData.IsIntensityMatch = IsIntensityMatch(song.Intensity, selectData.SongSelection.Intensity);

                        selectData.MatchingSongs.Add(songData);
                    }
                }
            }

            return View(selectData);
        }

        public bool IsIntensityMatch(int matchingSongIntensity, int selectedSongIntensity)
        {
            return matchingSongIntensity == selectedSongIntensity ||
                matchingSongIntensity == selectedSongIntensity - 1 ||
                matchingSongIntensity == selectedSongIntensity + 1;
        }

        public bool IsYearMatch(int matchingSongYear, int selectedSongYear)
        {
            return matchingSongYear == selectedSongYear ||
                matchingSongYear == selectedSongYear - 1 ||
                matchingSongYear == selectedSongYear + 1;
        }

        public bool IsGenreMatch(string matchingSongGenre, string selectedSongGenre)
        {
            return matchingSongGenre == selectedSongGenre;
        }

        private bool IsBpmInRange(int matchingSongBpm, int selectedSongBpm)
        {
            var upperBpm = selectedSongBpm + 3;
            var lowerBpm = selectedSongBpm - 1;
            var upperDoubleBpm = upperBpm * 2;
            var lowerDoubleBpm = lowerBpm * 2;
            var upperHalfBpm = upperBpm / 2;
            var lowerHalfBpm = lowerBpm / 2;

            return matchingSongBpm <= upperBpm && matchingSongBpm >= lowerBpm ||
                matchingSongBpm <= upperDoubleBpm && matchingSongBpm >= lowerDoubleBpm ||
                matchingSongBpm <= upperHalfBpm && matchingSongBpm >= lowerHalfBpm;
        }
    }
}

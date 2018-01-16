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
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Songs.ToListAsync());
        //}

        public async Task<IActionResult> Index(string searchString)
        {
            var songs = from s in _context.Songs
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                songs = songs.Where(s => s.Artist.Contains(searchString) || s.Title.Contains(searchString));
            }

            return View(await songs.ToListAsync());
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
            selectData.MatchingSongs = new List<SongData>();
            selectData.SongSelection = await _context.Songs.SingleOrDefaultAsync(m => m.ID == id);

            if (selectData.SongSelection == null)
            {
                return NotFound();
            }

            // save song selection into History
            var history = new History
            {
                Created = DateTime.Now,
                SongID = selectData.SongSelection.ID
            };

            _context.Add(history);
            await _context.SaveChangesAsync();

            var matchingSongs = new List<SongData>();
            var songs = await _context.Songs.ToListAsync();

            foreach (var song in songs)
            {
                if (song.ID != selectData.SongSelection.ID)
                {
                    if (IsBpmInRange(song.Bpm, selectData.SongSelection.Bpm))
                    {
                        var songData = new SongData{};
                        songData.Song = song;

                        songData.IsGenreMatch = IsGenreMatch(song.Genre, selectData.SongSelection.Genre);
                        songData.IsYearMatch = IsYearMatch(song.Year, selectData.SongSelection.Year);
                        songData.IsIntensityMatch = IsIntensityMatch(song.Intensity, selectData.SongSelection.Intensity);
                        songData.IsKeyMatch = IsKeyMatch(song.Key, selectData.SongSelection.Key);

                        var matchedCount = songData.IsGenreMatch ? 1 : 0;
                        matchedCount += songData.IsYearMatch ? 1 : 0;
                        matchedCount += songData.IsIntensityMatch ? 1 : 0;
                        matchedCount += songData.IsKeyMatch ? 10 : 0;

                        songData.MatchedCount = matchedCount;

                        matchingSongs.Add(songData);
                    }
                }
            }

            selectData.MatchingSongs = matchingSongs.OrderByDescending(a => a.MatchedCount).ThenBy(a => a.Song.Year).ToList();

            return View(selectData);
        }

        public bool IsKeyMatch(string matchingSongKey, string selectedSongKey)
        {
            var selectedSongTrailingKey = GetTrailingKey(selectedSongKey);
            var matchingSongLeadingKey = GetLeadingKey(matchingSongKey);

            var keyLetter = selectedSongTrailingKey.Contains("A") ? "A" : "B";

            var keyNumber = Convert.ToInt32(selectedSongTrailingKey.Replace("A", "").Replace("B", ""));

            var upperKeyNumber = keyNumber == 12 ? 1 : keyNumber + 1;
            var lowerKeyNumber = keyNumber == 1 ? 12 : keyNumber - 1;

            var upperKey = String.Concat(upperKeyNumber, keyLetter);
            var lowerKey = String.Concat(lowerKeyNumber, keyLetter);

            var otherKey = String.Concat(keyNumber, keyLetter == "A" ? "B" : "A");

            return matchingSongLeadingKey == selectedSongTrailingKey ||
                matchingSongLeadingKey == upperKey ||
                matchingSongLeadingKey == lowerKey ||
                matchingSongLeadingKey == otherKey;
        }

        private string GetLeadingKey(string matchingSongKey)
        {
            var leadingKey = string.Empty;

            if (matchingSongKey.Contains("_"))
            {
                leadingKey = matchingSongKey.Substring(0, matchingSongKey.IndexOf('_'));
            }
            else
            {
                leadingKey = matchingSongKey;
            }

            return leadingKey;
        }

        public string GetTrailingKey(string selectedSongKey)
        {
            var trailingKey = string.Empty;

            if (selectedSongKey.Contains("_"))
            {
                trailingKey = selectedSongKey.Substring(selectedSongKey.IndexOf('_') + 1);
            }
            else
            {
                trailingKey = selectedSongKey;
            }

            return trailingKey;
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

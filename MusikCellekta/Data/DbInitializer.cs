﻿using MusikCellekta.Models;
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

            var songs = new Song[]
            {
                // Dance 1
                new Song{Artist = "Snap!", Title = "The Power (LQ)", Bpm = 109, Key = "10A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 1, Genre = "Dance"},
                new Song{Artist = "C+C Music Factory", Title = "Gonna Make You Sweat (Everybody Dance Now) (LQ)", Bpm = 115, Key = "3A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 2, Genre = "Dance"},
                new Song{Artist = "Black Box", Title = "Ride on Time (LQ)", Bpm = 119, Key = "8A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 3, Genre = "Dance"},
                new Song{Artist = "Robin S.", Title = "Show Me Love", Bpm = 120, Key = "8A", Intensity = 6, Year = 1993, Disc = "Dance 1", Track = 4, Genre = "Dance"},
                new Song{Artist = "CeCe Peniston", Title = "Finally (LQ)", Bpm = 120, Key = "10A", Intensity = 7, Year = 1992, Disc = "Dance 1", Track = 5, Genre = "Dance"},
                new Song{Artist = "Deee-Lite", Title = "Groove Is in the Heart", Bpm = 122, Key = "1A", Intensity = 7, Year = 1990, Disc = "Dance 1", Track = 6, Genre = "Dance"},
                new Song{Artist = "Reel 2 Real", Title = "I Like to Move It (LQ)", Bpm = 123, Key = "5A", Intensity = 7, Year = 1993, Disc = "Dance 1", Track = 7, Genre = "Dance"},
                new Song{Artist = "Snap!", Title = "Rhythm Is a Dancer", Bpm = 124, Key = "8A", Intensity = 6, Year = 1992, Disc = "Dance 1", Track = 8, Genre = "Dance"},
                new Song{Artist = "Haddaway", Title = "What Is Love", Bpm = 124, Key = "7A", Intensity = 7, Year = 1993, Disc = "Dance 1", Track = 9, Genre = "Dance"},
                new Song{Artist = "Technotronic", Title = "Pump Up the Jam", Bpm = 125, Key = "5A", Intensity = 7, Year = 1989, Disc = "Dance 1", Track = 10, Genre = "Dance"},
                new Song{Artist = "M People", Title = "Moving on Up (LQ)", Bpm = 125, Key = "5A", Intensity = 7, Year = 1993, Disc = "Dance 1", Track = 11, Genre = "Dance"},
                new Song{Artist = "2 Unlimited", Title = "Get Ready for This (LQ)", Bpm = 125, Key = "9A", Intensity = 7, Year = 1992, Disc = "Dance 1", Track = 12, Genre = "Dance"},
                new Song{Artist = "Corona", Title = "Rhythm of the Night", Bpm = 128, Key = "4A", Intensity = 6, Year = 1993, Disc = "Dance 1", Track = 13, Genre = "Dance"},
                new Song{Artist = "Rednex", Title = "Cotton Eye Joe (LQ)", Bpm = 132, Key = "11B", Intensity = 7, Year = 1995, Disc = "Dance 1", Track = 14, Genre = "Dance"},
                new Song{Artist = "Culture Beat", Title = "Mr. Vain", Bpm = 133, Key = "8A", Intensity = 7, Year = 1993, Disc = "Dance 1", Track = 15, Genre = "Dance"},
                new Song{Artist = "Cher", Title = "Believe", Bpm = 133, Key = "2B", Intensity = 7, Year = 1998, Disc = "Dance 1", Track = 16, Genre = "Dance"},
                new Song{Artist = "La Bouche", Title = "Be my lover (LQ)", Bpm = 135, Key = "12A", Intensity = 7, Year = 1995, Disc = "Dance 1", Track = 17, Genre = "Dance"},
                new Song{Artist = "Sash!", Title = "Adelante (LQ)", Bpm = 136, Key = "11A_12A", Intensity = 7, Year = 2000, Disc = "Dance 1", Track = 18, Genre = "Dance"},

                // Disco 1
                new Song{Artist = "ABBA", Title = "Dancing Queen", Bpm = 100, Key = "11B", Intensity = 6, Year = 1976, Disc = "Disco 1", Track = 1, Genre = "Disco"},
                new Song{Artist = "Carl Douglas", Title = "Kung Fu Fighting (LQ)", Bpm = 102, Key = "10B", Intensity = 7, Year = 1974, Disc = "Disco 1", Track = 2, Genre = "Disco"},
                new Song{Artist = "Bee Gees", Title = "Stayin' Alive (LQ)", Bpm = 104, Key = "4A", Intensity = 7, Year = 1977, Disc = "Disco 1", Track = 3, Genre = "Disco"},
                new Song{Artist = "Bee Gees", Title = "Jive Talking (LQ)", Bpm = 106, Key = "8B", Intensity = 6, Year = 1975, Disc = "Disco 1", Track = 4, Genre = "Disco"},
                new Song{Artist = "KC & The Sunshine Band", Title = "That's the Way (I Like It) (LQ)", Bpm = 108, Key = "5A", Intensity = 7, Year = 1975, Disc = "Disco 1", Track = 5, Genre = "Disco"},
                new Song{Artist = "Diana Ross", Title = "I'm Coming Out (LQ)", Bpm = 109, Key = "7A", Intensity = 6, Year = 1980, Disc = "Disco 1", Track = 6, Genre = "Disco"},
                new Song{Artist = "Bee Gees", Title = "Night Fever (LQ)", Bpm = 109, Key = "11A", Intensity = 7, Year = 1977, Disc = "Disco 1", Track = 7, Genre = "Disco"},
                new Song{Artist = "Cheryl Lynn", Title = "Got to Be Real (LQ)", Bpm = 115, Key = "8A", Intensity = 7, Year = 1978, Disc = "Disco 1", Track = 8, Genre = "Disco"},
                new Song{Artist = "Gloria Gaynor", Title = "I Will Survive (LQ)", Bpm = 116, Key = "8A", Intensity = 6, Year = 1978, Disc = "Disco 1", Track = 9, Genre = "Disco"},
                new Song{Artist = "Rose Royce", Title = "Car Wash (LQ)", Bpm = 117, Key = "7A", Intensity = 4, Year = 1976, Disc = "Disco 1", Track = 10, Genre = "Disco"},
                new Song{Artist = "Sister Sledge", Title = "We Are Family (LQ)", Bpm = 120, Key = "4A", Intensity = 5, Year = 1979, Disc = "Disco 1", Track = 11, Genre = "Disco"},
                new Song{Artist = "Whitney Houston", Title = "I'm Every Woman (LQ)", Bpm = 120, Key = "5A", Intensity = 7, Year = 1992, Disc = "Disco 1", Track = 12, Genre = "Disco"},
                new Song{Artist = "Chic", Title = "Le Freak (LQ)", Bpm = 120, Key = "8A", Intensity =7, Year = 1978, Disc = "Disco 1", Track = 13, Genre = "Disco"},
                new Song{Artist = "Donna Summer", Title = "Hot Stuff (LQ)", Bpm = 121, Key = "6A", Intensity = 7, Year = 1979, Disc = "Disco 1", Track = 14, Genre = "Disco"},
                new Song{Artist = "Thelma Houston", Title = "Don't Leave Me This Way (LQ)", Bpm = 122, Key = "5A", Intensity = 6, Year = 1976, Disc = "Disco 1", Track = 15, Genre = "Disco"},
                new Song{Artist = "Anita Ward", Title = "Ring My Bell (LQ)", Bpm = 126, Key = "5A", Intensity = 6, Year = 1979, Disc = "Disco 1", Track = 16, Genre = "Disco"},
                new Song{Artist = "Village People", Title = "Y.M.C.A. (LQ)", Bpm = 127, Key = "2B", Intensity = 8, Year = 1978, Disc = "Disco 1", Track = 17, Genre = "Disco"},
                new Song{Artist = "Earth, Wind & Fire & The Emotions", Title = "Boogie Wonderland (LQ)", Bpm = 130, Key = "7A", Intensity = 7, Year = 1979, Disc = "Disco 1", Track = 18, Genre = "Disco"},
                new Song{Artist = "The Weather Girls", Title = "It's Raining Men", Bpm = 137, Key = "4A", Intensity = 7, Year = 1983, Disc = "Disco 1", Track = 19, Genre = "Disco"},
                new Song{Artist = "Amii Stewart", Title = "Knock on Wood (LQ)", Bpm = 144, Key = "11B", Intensity = 7, Year = 1966, Disc = "Disco 1", Track = 20, Genre = "Disco"},

                // Funk 1
                new Song{Artist = "Parliament", Title = "Flashlight (LQ)", Bpm = 105, Key = "5A", Intensity = 4, Year = 1977, Disc = "Funk 1", Track = 1, Genre = "Funk"},
                new Song{Artist = "Parliament", Title = "Give Up The Funk (LQ)", Bpm = 106, Key = "9A", Intensity = 5, Year = 1975, Disc = "Funk 1", Track = 2, Genre = "Funk"},
                new Song{Artist = "Kool & The Gang", Title = "Jungle Boogie", Bpm = 106, Key = "6A", Intensity = 6, Year = 1973, Disc = "Funk 1", Track = 3, Genre = "Funk"},
                new Song{Artist = "Bruno Mars", Title = "24K Magic", Bpm = 107, Key = "4A", Intensity = 7, Year = 2016, Disc = "Funk 1", Track = 4, Genre = "Funk"},
                new Song{Artist = "George Clinton", Title = "Atomic Dog (LQ)", Bpm = 108, Key = "10B", Intensity = 7, Year = 2011, Disc = "Funk 1", Track = 5, Genre = "Funk"},
                new Song{Artist = "Commodores", Title = "Brick House (LQ)", Bpm = 108, Key = "8A", Intensity = 5, Year = 1977, Disc = "Funk 1", Track = 6, Genre = "Funk"},
                new Song{Artist = "Wild Cherry", Title = "Play That Funky Music (LQ)", Bpm = 109, Key = "9A", Intensity = 7, Year = 1976, Disc = "Funk 1", Track = 7, Genre = "Funk"},
                new Song{Artist = "Brick", Title = "Dazz (LQ)", Bpm = 109, Key = "9A", Intensity = 7, Year = 1976, Disc = "Funk 1", Track = 8, Genre = "Funk"},
                new Song{Artist = "Indeep", Title = "Last Night A DJ Saved My Life (LQ)", Bpm = 110, Key = "11A", Intensity = 7, Year = 1982, Disc = "Funk 1", Track = 9, Genre = "Funk"},
                new Song{Artist = "Kurtis Blow", Title = "The Breaks", Bpm = 113, Key = "9A", Intensity = 6, Year = 1980, Disc = "Funk 1", Track = 10, Genre = "Funk"},
                new Song{Artist = "Mark Ronson feat. Bruno Mars", Title = "Uptown Funk", Bpm = 115, Key = "7A", Intensity = 7, Year = 2014, Disc = "Funk 1", Track = 11, Genre = "Funk"},
                new Song{Artist = "Patrice Rushen", Title = "Forget Me Nots (LQ)", Bpm = 114, Key = "11A", Intensity = 6, Year = 1982, Disc = "Funk 1", Track = 12, Genre = "Funk"},
                new Song{Artist = "Cameo", Title = "Word Up", Bpm = 116, Key = "11A", Intensity = 7, Year = 1986, Disc = "Funk 1", Track = 13, Genre = "Funk"},
                new Song{Artist = "Ohio Players", Title = "Love Rollercoaster (LQ)", Bpm = 117, Key = "8A", Intensity = 7, Year = 1975, Disc = "Funk 1", Track = 14, Genre = "Funk"},
                new Song{Artist = "Prince", Title = "1999 (LQ)", Bpm = 119, Key = "7B", Intensity = 7, Year = 1982, Disc = "Funk 1", Track = 15, Genre = "Funk"},
                new Song{Artist = "Eddy Grant", Title = "Electric Avenue (LQ)", Bpm = 121, Key = "11B", Intensity = 7, Year = 1982, Disc = "Funk 1", Track = 16, Genre = "Funk"},
                new Song{Artist = "Prince", Title = "Little Red Corvette (LQ)", Bpm = 123, Key = "3B", Intensity = 6, Year = 1982, Disc = "Funk 1", Track = 17, Genre = "Funk"},
                new Song{Artist = "Rick James", Title = "Super Freak", Bpm = 132, Key = "8A", Intensity = 7, Year = 1981, Disc = "Funk 1", Track = 18, Genre = "Funk"},

                //  Hip hop 1
                new Song{Artist = "The Notorious B.I.G.", Title = "Big Poppa", Bpm = 85, Key = "8B", Intensity = 6, Year = 1994, Disc = "Hip hop 1", Track = 1, Genre = "Hip hop"},
                new Song{Artist = "The Notorious B.I.G.", Title = "Juicy", Bpm = 97, Key = "12B", Intensity = 6, Year = 1994, Disc = "Hip hop 1", Track = 2, Genre = "Hip hop"},
                new Song{Artist = "A Tribe Called Quest", Title = "Can I Kick It", Bpm = 97, Key = "7B", Intensity = 4, Year = 1990, Disc = "Hip hop 1", Track = 3, Genre = "Hip hop"},
                new Song{Artist = "Snow", Title = "Informer (LQ)", Bpm = 98, Key = "1A", Intensity = 7, Year = 1993, Disc = "Hip hop 1", Track = 4, Genre = "Hip hop"},
                new Song{Artist = "Naughty by Nature feat. Phiness", Title = "Holiday (LQ)", Bpm = 100, Key = "11A", Intensity = 7, Year = 1999, Disc = "Hip hop 1", Track = 5, Genre = "Hip hop"},
                new Song{Artist = "Ini Kamoze", Title = "Here Comes the Hotstepper", Bpm = 100, Key = "10A", Intensity = 6, Year = 1994, Disc = "Hip hop 1", Track = 6, Genre = "Hip hop"},
                new Song{Artist = "Run-DMC", Title = "Walk This Way", Bpm = 106, Key = "8A", Intensity = 7, Year = 1986, Disc = "Hip hop 1", Track = 7, Genre = "Hip hop"},
                new Song{Artist = "Nelly", Title = "Hot In Herre (LQ)", Bpm = 107, Key = "9A", Intensity = 6, Year = 2002, Disc = "Hip hop 1", Track = 8, Genre = "Hip hop"},
                new Song{Artist = "Arrested Development", Title = "Mr. Wendal", Bpm = 110, Key = "5B", Intensity = 5, Year = 1992, Disc = "Hip hop 1", Track = 9, Genre = "Hip hop"},
                new Song{Artist = "Rob Base & DJ E-Z Rock", Title = "It Takes Two", Bpm = 113, Key = "6A", Intensity = 7, Year = 1988, Disc = "Hip hop 1", Track = 10, Genre = "Hip hop"},
                new Song{Artist = "Vanilla Ice", Title = "Ice Ice Baby", Bpm = 116, Key = "7A", Intensity = 6, Year = 1990, Disc = "Hip hop 1", Track = 11, Genre = "Hip hop"},
                new Song{Artist = "Young MC", Title = "Bust a Move", Bpm = 118, Key = "9A", Intensity = 7, Year = 1989, Disc = "Hip hop 1", Track = 12, Genre = "Hip hop"},
                new Song{Artist = "Tone-Loc", Title = "Funky Cold Medina (LQ)", Bpm = 118, Key = "5A_6A", Intensity = 6, Year = 1989, Disc = "Hip hop 1", Track = 13, Genre = "Hip hop"},
                new Song{Artist = "Marky Mark and The Funky Bunch", Title = "Good Vibrations (LQ)", Bpm = 122, Key = "4B", Intensity = 7, Year = 1991, Disc = "Hip hop 1", Track = 14, Genre = "Hip hop"},
                new Song{Artist = "Tone Loc", Title = "Wild Thing", Bpm = 126, Key = "5A", Intensity = 7, Year = 1989, Disc = "Hip hop 1", Track = 15, Genre = "Hip hop"},
                new Song{Artist = "Salt-N-Pepa", Title = "Push It", Bpm = 128, Key = "9A", Intensity = 7, Year = 1986, Disc = "Hip hop 1", Track = 16, Genre = "Hip hop"},
                new Song{Artist = "Run-D.M.C.", Title = "It's Tricky", Bpm = 128, Key = "8A", Intensity = 7, Year = 1986, Disc = "Hip hop 1", Track = 17, Genre = "Hip hop"},
                new Song{Artist = "Tag Team", Title = "Whoomp (There It Is) (LQ)", Bpm = 129, Key = "4A", Intensity = 6, Year = 1993, Disc = "Hip hop 1", Track = 18, Genre = "Hip hop"},
                new Song{Artist = "Sir Mix-A-Lot", Title = "Baby Got Back (LQ)", Bpm = 129, Key = "4A", Intensity = 7, Year = 1992, Disc = "Hip hop 1", Track = 19, Genre = "Hip hop"},
                new Song{Artist = "M.C. Hammer", Title = "U Can't Touch This", Bpm = 133, Key = "7A", Intensity = 8, Year = 1999, Disc = "Hip hop 1", Track = 20, Genre = "Hip hop"},

                // Pop 1
                new Song{Artist = "Los Lobos", Title = "La Bamba", Bpm = 78, Key = "9B", Intensity = 7, Year = 1987, Disc = "Pop 1", Track = 1, Genre = "Pop"},
                new Song{Artist = "a-ha", Title = "Take on Me (LQ)", Bpm = 84, Key = "11B", Intensity = 7, Year = 1985, Disc = "Pop 1", Track = 2, Genre = "Pop"},
                new Song{Artist = "Toto", Title = "Africa", Bpm = 92, Key = "11B", Intensity = 6, Year = 1982, Disc = "Pop 1", Track = 3, Genre = "Pop"},
                new Song{Artist = "Culture Club", Title = "Karma Chameleon", Bpm = 92, Key = "6B", Intensity = 5, Year = 1983, Disc = "Pop 1", Track = 4, Genre = "Pop"},
                new Song{Artist = "Daryl Braithwaite", Title = "The Horses (LQ)", Bpm = 94, Key = "12B", Intensity = 6, Year = 1990, Disc = "Pop 1", Track = 5, Genre = "Pop"},
                new Song{Artist = "Len", Title = "Steal my Sunshine", Bpm = 96, Key = "12B", Intensity = 6, Year = 1999, Disc = "Pop 1", Track = 6, Genre = "Pop"},
                new Song{Artist = "Los del Río", Title = "Macarena (LQ)", Bpm = 103, Key = "4B", Intensity = 7, Year = 1993, Disc = "Pop 1", Track = 7, Genre = "Pop"},
                new Song{Artist = "Bangles", Title = "Walk Like An Egyptian", Bpm = 103, Key = "10A_1B", Intensity = 6, Year = 1986, Disc = "Pop 1", Track = 8, Genre = "Pop"},
                new Song{Artist = "Hanson", Title = "MMMBop", Bpm = 105, Key = "11B", Intensity = 7, Year = 1996, Disc = "Pop 1", Track = 9, Genre = "Pop"},
                new Song{Artist = "Dexys Midnight Runners", Title = "Come On Eileen", Bpm = 108, Key = "8A", Intensity = 6, Year = 1982, Disc = "Pop 1", Track = 10, Genre = "Pop"},
                new Song{Artist = "Blondie", Title = "Rapture", Bpm = 108, Key = "9A", Intensity = 7, Year = 1980, Disc = "Pop 1", Track = 11, Genre = "Pop"},
                new Song{Artist = "Bananarama", Title = "Cruel Summer", Bpm = 108, Key = "12A", Intensity = 7, Year = 1984, Disc = "Pop 1", Track = 12, Genre = "Pop"},
                new Song{Artist = "Rick Astley", Title = "Never Gonna Give You Up", Bpm = 113, Key = "4B", Intensity = 7, Year = 1987, Disc = "Pop 1", Track = 13, Genre = "Pop"},
                new Song{Artist = "Billy Ocean", Title = "Caribbean Queen [No More Love On The Run]", Bpm = 114, Key = "7A", Intensity = 5, Year = 2008, Disc = "Pop 1", Track = 14, Genre = "Pop"},
                new Song{Artist = "Madonna", Title = "Holiday", Bpm = 116, Key = "10A", Intensity = 7, Year = 1983, Disc = "Pop 1", Track = 15, Genre = "Pop"},
                new Song{Artist = "Billy Ocean", Title = "Get Outta My Dreams, Get Into My Car", Bpm = 117, Key = "12B", Intensity = 7, Year = 1989, Disc = "Pop 1", Track = 16, Genre = "Pop"},
                new Song{Artist = "Cyndi Lauper", Title = "Girls Just Want To Have Fun (LQ)", Bpm = 121, Key = "2B", Intensity = 7, Year = 1983, Disc = "Pop 1", Track = 17, Genre = "Pop"},
                new Song{Artist = "Right Said Fred", Title = "I'm too Sexy (LQ)", Bpm = 122, Key = "12B", Intensity = 7, Year = 1992, Disc = "Pop 1", Track = 18, Genre = "Pop"},
                new Song{Artist = "Bananarama", Title = "Venus", Bpm = 126, Key = "9A", Intensity = 7, Year = 1986, Disc = "Pop 1", Track = 19, Genre = "Pop"},
                new Song{Artist = "Neil Diamond", Title = "Cracklin' Rosie (LQ)", Bpm = 128, Key = "2A", Intensity = 6, Year = 1970, Disc = "Pop 1", Track = 20, Genre = "Pop"},

                // Pop 2
                new Song{Artist = "Elton John", Title = "Tiny Dancer", Bpm = 73, Key = "8B", Intensity = 4, Year = 1971, Disc = "Pop 2", Track = 1, Genre = "Pop"},
                new Song{Artist = "Bangles", Title = "Eternal Flame", Bpm = 79, Key = "9B", Intensity = 5, Year = 1988, Disc = "Pop 2", Track = 2, Genre = "Pop"},
                new Song{Artist = "Luis Fonsi & Daddy Yankee", Title = "Despacito", Bpm = 89, Key = "10A", Intensity = 7, Year = 2017, Disc = "Pop 2", Track = 3, Genre = "Pop"},
                new Song{Artist = "The Weeknd feat. Daft Punk", Title = "I Feel It Coming", Bpm = 93, Key = "5A", Intensity = 6, Year = 2016, Disc = "Pop 2", Track = 4, Genre = "Pop"},
                new Song{Artist = "Katy Perry feat. Skip Marley", Title = "Chained to the Rhythm", Bpm = 95, Key = "8A", Intensity = 6, Year = 2017, Disc = "Pop 2", Track = 5, Genre = "Pop"},
                new Song{Artist = "Ed Sheeran", Title = "Shape of You", Bpm = 96, Key = "11A", Intensity = 5, Year = 2017, Disc = "Pop 2", Track = 6, Genre = "Pop"},
                new Song{Artist = "Wilson Phillips", Title = "Hold On", Bpm = 98, Key = "7B", Intensity = 6, Year = 1990, Disc = "Pop 2", Track = 7, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Man in the Mirror", Bpm = 100, Key = "9B", Intensity = 6, Year = 1987, Disc = "Pop 2", Track = 8, Genre = "Pop"},
                new Song{Artist = "Roxette", Title = "Joyride (LQ)", Bpm = 102, Key = "11B", Intensity = 7, Year = 1991, Disc = "Pop 2", Track = 9, Genre = "Pop"},
                new Song{Artist = "Neneh Cherry", Title = "Buffalo Stance", Bpm = 107, Key = "4A", Intensity = 7, Year = 1989, Disc = "Pop 2", Track = 10, Genre = "Pop"},
                new Song{Artist = "The Weeknd", Title = "Can't Feel My Face", Bpm = 108, Key = "8A", Intensity = 6, Year = 2015, Disc = "Pop 2", Track = 11, Genre = "Pop"},
                new Song{Artist = "NEIKED feat. Dyo", Title = "Sexual", Bpm = 108, Key = "10B", Intensity = 7, Year = 2016, Disc = "Pop 2", Track = 12, Genre = "Pop"},
                new Song{Artist = "Simple Minds", Title = "Don't You Forget About Me", Bpm = 111, Key = "11B", Intensity = 6, Year = 1985, Disc = "Pop 2", Track = 13, Genre = "Pop"},
                new Song{Artist = "John Farnham", Title = "Pressure Down (LQ)", Bpm = 112, Key = "2B", Intensity = 7, Year = 1986, Disc = "Pop 2", Track = 14, Genre = "Pop"},
                new Song{Artist = "Sheryl Crow", Title = "All I Wanna Do", Bpm = 120, Key = "9A", Intensity = 5, Year = 1999, Disc = "Pop 2", Track = 15, Genre = "Pop"},
                new Song{Artist = "Bangles", Title = "Manic Monday", Bpm = 122, Key = "10B", Intensity = 7, Year = 1986, Disc = "Pop 2", Track = 16, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "P.Y.T. (Pretty Young Thing)", Bpm = 127, Key = "10A", Intensity = 6, Year = 1982, Disc = "Pop 2", Track = 17, Genre = "Pop"},
                new Song{Artist = "Depeche Mode", Title = "Just Can't Get Enough (LQ)", Bpm = 127, Key = "9B", Intensity = 7, Year = 1981, Disc = "Pop 2", Track = 18, Genre = "Pop"},
                new Song{Artist = "Mike Posner", Title = "Cooler Than Me", Bpm = 130, Key = "6A", Intensity = 7, Year = 2009, Disc = "Pop 2", Track = 19, Genre = "Pop"},

                // Pop 3
                new Song{Artist = "Niall Horan", Title = "Slow Hands", Bpm = 86, Key = "8A", Intensity = 7, Year = 2017, Disc = "Pop 3", Track = 1, Genre = "Pop"},
                new Song{Artist = "The Pointer Sisters", Title = "I'm So Excited (12 remix) (LQ)", Bpm = 91, Key = "6A", Intensity = 6, Year = 1982, Disc = "Pop 3", Track = 2, Genre = "Pop"},
                new Song{Artist = "Nena", Title = "99 Red Balloons", Bpm = 97, Key = "12B", Intensity = 6, Year = 1984, Disc = "Pop 3", Track = 3, Genre = "Pop"},
                new Song{Artist = "Steve Winwood", Title = "Higher Love", Bpm = 99, Key = "7A", Intensity = 6, Year = 1986, Disc = "Pop 3", Track = 4, Genre = "Pop"},
                new Song{Artist = "Shakira feat. Wyclef Jean", Title = "Hips Don't Lie (LQ)", Bpm = 100, Key = "3A", Intensity = 5, Year = 2005, Disc = "Pop 3", Track = 5, Genre = "Pop"},
                new Song{Artist = "Culture Club", Title = "Do You Really Want to Hurt Me", Bpm = 100, Key = "9B", Intensity = 4, Year = 1982, Disc = "Pop 3", Track = 6, Genre = "Pop"},
                new Song{Artist = "Frankie Valli", Title = "December, 1963 (Oh What a Night) (LQ)", Bpm = 104, Key = "3B", Intensity = 6, Year = 1975, Disc = "Pop 3", Track = 7, Genre = "Pop"},
                new Song{Artist = "Hot Chocolate", Title = "You Sexy Thing (LQ)", Bpm = 106, Key = "7B", Intensity = 5, Year = 1975, Disc = "Pop 3", Track = 8, Genre = "Pop"},
                new Song{Artist = "Katrina & The Waves", Title = "Walking on Sunshine", Bpm = 110, Key = "6B", Intensity = 7, Year = 1986, Disc = "Pop 3", Track = 9, Genre = "Pop"},
                new Song{Artist = "Frankie Goes to Hollywood", Title = "Relax", Bpm = 115, Key = "9A", Intensity = 7, Year = 1984, Disc = "Pop 3", Track = 10, Genre = "Pop"},
                new Song{Artist = "Blondie", Title = "Heart of Glass", Bpm = 115, Key = "12B", Intensity = 7, Year = 1978, Disc = "Pop 3", Track = 11, Genre = "Pop"},
                new Song{Artist = "Barry Manilow", Title = "Copacabana (LQ)", Bpm = 116, Key = "5A", Intensity = 7, Year = 1978, Disc = "Pop 3", Track = 12, Genre = "Pop"},
                new Song{Artist = "The Human League", Title = "Don't You Want Me", Bpm = 117, Key = "8B", Intensity = 7, Year = 1981, Disc = "Pop 3", Track = 13, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Billie Jean", Bpm = 117, Key = "11A", Intensity = 6, Year = 1982, Disc = "Pop 3", Track = 14, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Don't Stop 'til You Get Enough", Bpm = 119, Key = "1B", Intensity = 7, Year = 1979, Disc = "Pop 3", Track = 15, Genre = "Pop"},
                new Song{Artist = "ABC", Title = "The Look of Love", Bpm = 121, Key = "8A", Intensity = 7, Year = 1982, Disc = "Pop 3", Track = 16, Genre = "Pop"},
                new Song{Artist = "Lipps, Inc.", Title = "Funkytown", Bpm = 122, Key = "5A", Intensity = 6, Year = 1979, Disc = "Pop 3", Track = 17, Genre = "Pop"},
                new Song{Artist = "KC and The Sunshine Band", Title = "Give It Up", Bpm = 125, Key = "5B", Intensity = 7, Year = 1982, Disc = "Pop 3", Track = 18, Genre = "Pop"},
                new Song{Artist = "Madness", Title = "House of Fun", Bpm = 127, Key = "8A_9A", Intensity = 7, Year = 1992, Disc = "Pop 3", Track = 19, Genre = "Pop"},

                // Pop 4
                new Song{Artist = "Kim Wilde", Title = "Kids in America (LQ)", Bpm = 80, Key = "10A", Intensity = 6, Year = 1981, Disc = "Pop 4", Track = 1, Genre = "Pop"},
                new Song{Artist = "Meghan Trainor", Title = "Dear Future Husband", Bpm = 80, Key = "3B_10B", Intensity = 6, Year = 2015, Disc = "Pop 4", Track = 2, Genre = "Pop"},
                new Song{Artist = "Wham!", Title = "Wake Me Up Before You Go-Go (LQ)", Bpm = 82, Key = "8B", Intensity = 6, Year = 1984, Disc = "Pop 4", Track = 3, Genre = "Pop"},
                new Song{Artist = "JoJo", Title = "Leave (Get Out) (LQ)", Bpm = 87, Key = "7A", Intensity = 7, Year = 2004, Disc = "Pop 4", Track = 4, Genre = "Pop"},
                new Song{Artist = "Kenny Loggins", Title = "Footloose", Bpm = 87, Key = "8A", Intensity = 7, Year = 1984, Disc = "Pop 4", Track = 5, Genre = "Pop"},
                new Song{Artist = "The B-52s", Title = "Rock Lobster (LQ)", Bpm = 92, Key = "5A", Intensity = 5, Year = 1979, Disc = "Pop 4", Track = 6, Genre = "Pop"},
                new Song{Artist = "Ed Sheeran", Title = "Galway Girl", Bpm = 100, Key = "11B", Intensity = 7, Year = 2017, Disc = "Pop 4", Track = 7, Genre = "Pop"},
                new Song{Artist = "Men Without Hats", Title = "The Safety Dance", Bpm = 102, Key = "5A", Intensity = 7, Year = 1982, Disc = "Pop 4", Track = 8, Genre = "Pop"},
                new Song{Artist = "Pet Shop Boys", Title = "West End Girls", Bpm = 113, Key = "9A", Intensity = 7, Year = 1984, Disc = "Pop 4", Track = 9, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Rock With You", Bpm = 114, Key = "3A", Intensity = 7, Year = 1983, Disc = "Pop 4", Track = 10, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Thriller", Bpm = 119, Key = "12A", Intensity = 6, Year = 1982, Disc = "Pop 4", Track = 11, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Wanna Be Startin` Somethin`", Bpm = 122, Key = "10B", Intensity = 7, Year = 1983, Disc = "Pop 4", Track = 12, Genre = "Pop"},
                new Song{Artist = "Irene Cara", Title = "Flashdance... What a Feeling", Bpm = 123, Key = "5A", Intensity = 6, Year = 1983, Disc = "Pop 4", Track = 13, Genre = "Pop"},
                new Song{Artist = "Eurythmics", Title = "Sweet Dreams (LQ)", Bpm = 126, Key = "5A", Intensity = 7, Year = 1983, Disc = "Pop 4", Track = 14, Genre = "Pop"},
                new Song{Artist = "Dead Or Alive", Title = "You Spin Me Round (Like A Record)", Bpm = 128, Key = "11A", Intensity = 7, Year = 1985, Disc = "Pop 4", Track = 15, Genre = "Pop"},
                new Song{Artist = "The Go-Go's", Title = "Our Lips Are Sealed (LQ)", Bpm = 130, Key = "4B", Intensity = 7, Year = 1981, Disc = "Pop 4", Track = 16, Genre = "Pop"},
                new Song{Artist = "The B-52s", Title = "Love Shack (LQ)", Bpm = 134, Key = "5A", Intensity = 7, Year = 1989, Disc = "Pop 4", Track = 17, Genre = "Pop"},
                new Song{Artist = "The Cure", Title = "Friday I'm in Love (LQ)", Bpm = 136, Key = "6B", Intensity = 7, Year = 1992, Disc = "Pop 4", Track = 18, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Beat It", Bpm = 139, Key = "2A", Intensity = 7, Year = 1982, Disc = "Pop 4", Track = 19, Genre = "Pop"},
                new Song{Artist = "Soft Cell", Title = "Tainted Love", Bpm = 143, Key = "5A", Intensity = 7, Year = 1981, Disc = "Pop 4", Track = 20, Genre = "Pop"},

                // Pop 5
                new Song{Artist = "Michael Sembello", Title = "Maniac (LQ)", Bpm = 80, Key = "2A", Intensity = 7, Year = 1983, Disc = "Pop 5", Track = 1, Genre = "Pop"},
                new Song{Artist = "Ace of Base", Title = "All That She Wants", Bpm = 94, Key = "12A", Intensity = 5, Year = 1992, Disc = "Pop 5", Track = 2, Genre = "Pop"},
                new Song{Artist = "Fine Young Cannibals", Title = "She Drives Me Crazy (LQ)", Bpm = 109, Key = "10B", Intensity = 6, Year = 1988, Disc = "Pop 5", Track = 3, Genre = "Pop"},
                new Song{Artist = "Prince and The Revolution", Title = "Kiss (LQ)", Bpm = 111, Key = "8A", Intensity = 7, Year = 1986, Disc = "Pop 5", Track = 4, Genre = "Pop"},
                new Song{Artist = "Bow Wow Wow", Title = "I Want Candy", Bpm = 112, Key = "10B", Intensity = 7, Year = 1982, Disc = "Pop 5", Track = 5, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "Bad", Bpm = 114, Key = "4A", Intensity = 7, Year = 1987, Disc = "Pop 5", Track = 6, Genre = "Pop"},
                new Song{Artist = "Londonbeat", Title = "I've Been Thinking About You (LQ)", Bpm = 114, Key = "10A", Intensity = 6, Year = 1990, Disc = "Pop 5", Track = 7, Genre = "Pop"},
                new Song{Artist = "Michael Jackson", Title = "The Way You Make Me Feel", Bpm = 115, Key = "4A", Intensity = 7, Year = 1987, Disc = "Pop 5", Track = 8, Genre = "Pop"},
                new Song{Artist = "Madonna", Title = "Vogue (LQ)", Bpm = 116, Key = "2A", Intensity = 7, Year = 1990, Disc = "Pop 5", Track = 9, Genre = "Pop"},
                new Song{Artist = "Madonna", Title = "Like a Virgin (LQ)", Bpm = 120, Key = "2A", Intensity = 7, Year = 1984, Disc = "Pop 5", Track = 10, Genre = "Pop"},
                new Song{Artist = "Gloria Estefan & Miami Sound Machine", Title = "Conga", Bpm = 123, Key = "9A", Intensity = 7, Year = 1985, Disc = "Pop 5", Track = 11, Genre = "Pop"},
                new Song{Artist = "Rockwell", Title = "Somebody's Watching Me", Bpm = 124, Key = "12A", Intensity = 6, Year = 1984, Disc = "Pop 5", Track = 12, Genre = "Pop"},
                new Song{Artist = "Buster Poindexter", Title = "Hot Hot Hot (LQ)", Bpm = 128, Key = "8B", Intensity = 6, Year = 1987, Disc = "Pop 5", Track = 13, Genre = "Pop"},
                new Song{Artist = "Corey Hart", Title = "Sunglasses at Night (LQ)", Bpm = 128, Key = "3A", Intensity = 6, Year = 1984, Disc = "Pop 5", Track = 14, Genre = "Pop"},
                new Song{Artist = "Kylie Minogue", Title = "The Locomotion (LQ)", Bpm = 129, Key = "5B", Intensity = 7, Year = 1988, Disc = "Pop 5", Track = 15, Genre = "Pop"},
                new Song{Artist = "Duran Duran", Title = "Hungry Like the Wolf", Bpm = 129, Key = "9A", Intensity = 7, Year = 1982, Disc = "Pop 5", Track = 16, Genre = "Pop"},
                new Song{Artist = "Laura Branigan", Title = "Gloria (LQ)", Bpm = 131, Key = "11B", Intensity = 7, Year = 1982, Disc = "Pop 5", Track = 17, Genre = "Pop"},
                new Song{Artist = "Rick Springfield", Title = "Jessie's Girl", Bpm = 132, Key = "10B", Intensity = 7, Year = 1981, Disc = "Pop 5", Track = 18, Genre = "Pop"},
                new Song{Artist = "Madonna", Title = "Material Girl (LQ)", Bpm = 137, Key = "8B", Intensity = 7, Year = 1984, Disc = "Pop 5", Track = 19, Genre = "Pop"},
                new Song{Artist = "Toni Basil", Title = "Mickey (LQ)", Bpm = 149, Key = "8A_10A", Intensity = 7, Year = 1981, Disc = "Pop 5", Track = 20, Genre = "Pop"},
                new Song{Artist = "DEVO", Title = "Whip It (LQ)", Bpm = 158, Key = "10B", Intensity = 7, Year = 1980, Disc = "Pop 5", Track = 21, Genre = "Pop"},

                // R&B 1
                new Song{Artist = "Jean Knight", Title = "Mr. Big Stuff", Bpm = 94, Key = "5B", Intensity = 6, Year = 1994, Disc = "R&B 1", Track = 1, Genre = "R&B"},
                new Song{Artist = "Beyoncé", Title = "Naughty Girl (LQ)", Bpm = 100, Key = "12A", Intensity = 6, Year = 2003, Disc = "R&B 1", Track = 2, Genre = "R&B"},
                new Song{Artist = "Bobby Brown", Title = "Every Little Step", Bpm = 100, Key = "1B", Intensity = 7, Year = 1988, Disc = "R&B 1", Track = 3, Genre = "R&B"},
                new Song{Artist = "Mariah Carey", Title = "Fantasy (LQ)", Bpm = 102, Key = "9A", Intensity = 7, Year = 1995, Disc = "R&B 1", Track = 4, Genre = "R&B"},
                new Song{Artist = "Tom Tom Club", Title = "Genius of Love (LQ)", Bpm = 103, Key = "9A", Intensity = 5, Year = 1981, Disc = "R&B 1", Track = 5, Genre = "R&B"},
                new Song{Artist = "Nu Shooz", Title = "I Can't Wait (LQ)", Bpm = 104, Key = "6A", Intensity = 6, Year = 1986, Disc = "R&B 1", Track = 6, Genre = "R&B"},
                new Song{Artist = "Marcia Griffiths", Title = "Electric Boogie (LQ)", Bpm = 107, Key = "3B", Intensity = 6, Year = 1990, Disc = "R&B 1", Track = 7, Genre = "R&B"},
                new Song{Artist = "Lionel Richie", Title = "All Night Long (All Night) (LQ)", Bpm = 109, Key = "4B", Intensity = 6, Year = 1983, Disc = "R&B 1", Track = 8, Genre = "R&B"},
                new Song{Artist = "Kool & The Gang", Title = "Get Down on It", Bpm = 110, Key = "9B", Intensity = 5, Year = 1981, Disc = "R&B 1", Track = 9, Genre = "R&B"},
                new Song{Artist = "Ciara feat. Missy Elliott", Title = "1, 2 Step (LQ)", Bpm = 113, Key = "6A", Intensity = 6, Year = 2004, Disc = "R&B 1", Track = 10, Genre = "R&B"},
                new Song{Artist = "Midnight Star", Title = "Midas Touch", Bpm = 117, Key = "5A", Intensity = 7, Year = 1986, Disc = "R&B 1", Track = 11, Genre = "R&B"},
                new Song{Artist = "Whitney Houston", Title = "I Wanna Dance With Somebody (LQ)", Bpm = 119, Key = "2B", Intensity = 6, Year = 1987, Disc = "R&B 1", Track = 12, Genre = "R&B"},
                new Song{Artist = "Kool & The Gang", Title = "Celebration", Bpm = 122, Key = "4B", Intensity = 6, Year = 1980, Disc = "R&B 1", Track = 13, Genre = "R&B"},
                new Song{Artist = "Deniece Williams", Title = "Let's Hear It for the Boy", Bpm = 124, Key = "9B", Intensity = 7, Year = 1984, Disc = "R&B 1", Track = 14, Genre = "R&B"},
                new Song{Artist = "Chaka Khan", Title = "I Feel for You (LQ)", Bpm = 125, Key = "1B", Intensity = 7, Year = 1984, Disc = "R&B 1", Track = 15, Genre = "R&B"},
                new Song{Artist = "Earth, Wind & Fire", Title = "Let's Groove (LQ)", Bpm = 126, Key = "10A", Intensity = 6, Year = 1981, Disc = "R&B 1", Track = 16, Genre = "R&B"},
                new Song{Artist = "Womack & Womack", Title = "Teardrops", Bpm = 133, Key = "2B", Intensity = 6, Year = 1988, Disc = "R&B 1", Track = 17, Genre = "R&B"},
                new Song{Artist = "Donna Summer", Title = "She Works Hard for the Money (LQ)", Bpm = 136, Key = "1A", Intensity = 7, Year = 1983, Disc = "R&B 1", Track = 17, Genre = "R&B"},

                // Rock 1
                new Song{Artist = "Queen", Title = "Bohemian Rhapsody", Bpm = 71, Key = "6B", Intensity = 5, Year = 1975, Disc = "Rock 1", Track = 1, Genre = "Rock"},
                new Song{Artist = "Cat Stevens", Title = "Peace Train (LQ)", Bpm = 84, Key = "8B", Intensity = 4, Year = 1971, Disc = "Rock 1", Track = 2, Genre = "Rock"},
                new Song{Artist = "John Farnham", Title = "You're the Voice", Bpm = 85, Key = "6B_4A", Intensity = 5, Year = 1986, Disc = "Rock 1", Track = 3, Genre = "Rock"},
                new Song{Artist = "Australian Crawl", Title = "Boys Light Up (LQ)", Bpm = 99, Key = "10A ", Intensity = 5, Year = 1980, Disc = "Rock 1", Track = 4, Genre = "Rock"},
                new Song{Artist = "Men At Work", Title = "Down Under", Bpm = 107, Key = "10B", Intensity = 6, Year = 1980, Disc = "Rock 1", Track = 5, Genre = "Rock"},
                new Song{Artist = "Queen", Title = "Somebody to Love", Bpm = 109, Key = "4B", Intensity = 4, Year = 1976, Disc = "Rock 1", Track = 6, Genre = "Rock"},
                new Song{Artist = "Queen ft David Bowie", Title = "Under Pressure", Bpm = 113, Key = "10B", Intensity = 5, Year = 1982, Disc = "Rock 1", Track = 7, Genre = "Rock"},
                new Song{Artist = "David Bowie", Title = "Let's Dance", Bpm = 113, Key = "3A", Intensity = 7, Year = 1983, Disc = "Rock 1", Track = 8, Genre = "Rock"},
                new Song{Artist = "Bruce Springsteen", Title = "Born in the U.S.A.", Bpm = 124, Key = "1B", Intensity = 7, Year = 1984, Disc = "Rock 1", Track = 9, Genre = "Rock"},
                new Song{Artist = "ACDC", Title = "You Shook Me All Night Long", Bpm = 129, Key = "9B ", Intensity = 7, Year = 1980, Disc = "Rock 1", Track = 10, Genre = "Rock"},
                new Song{Artist = "Men At Work", Title = "Who Can It Be Now", Bpm = 130, Key = "12A", Intensity = 7, Year = 1981, Disc = "Rock 1", Track = 11, Genre = "Rock"},
                new Song{Artist = "Fleetwood Mac", Title = "Gypsy", Bpm = 132, Key = "7B", Intensity = 5, Year = 1982, Disc = "Rock 1", Track = 12, Genre = "Rock"},
                new Song{Artist = "Fleetwood Mac", Title = "Go Your Own Way", Bpm = 135, Key = "7B", Intensity = 7, Year = 1977, Disc = "Rock 1", Track = 13, Genre = "Rock"},
                new Song{Artist = "Billy Idol", Title = "Mony,mony (LQ)", Bpm = 135, Key = "11A ", Intensity = 7, Year = 1981, Disc = "Rock 1", Track = 14, Genre = "Rock"},
                new Song{Artist = "Bryan Adams", Title = "Summer of '69", Bpm = 139, Key = "10B", Intensity = 7, Year = 1984, Disc = "Rock 1", Track = 15, Genre = "Rock"},
                new Song{Artist = "Billy Joel", Title = "It's Still Rock And Roll To Me", Bpm = 141, Key = "8B ", Intensity = 6, Year = 1980, Disc = "Rock 1", Track = 16, Genre = "Rock"},
                new Song{Artist = "Blondie", Title = "Call Me", Bpm = 143, Key = "7A", Intensity = 7, Year = 1980, Disc = "Rock 1", Track = 17, Genre = "Rock"},
                new Song{Artist = "Queen", Title = "Don't Stop Me Now", Bpm = 77, Key = "7B", Intensity = 6, Year = 1978, Disc = "Rock 1", Track = 18, Genre = "Rock"},

                // Rock 2
                new Song{Artist = "Gary Moore", Title = "Still Got the Blues (LQ)", Bpm = 81, Key = "8A", Intensity = 4, Year = 1990, Disc = "Rock 2", Track = 1, Genre = "Rock"},
                new Song{Artist = "Def Leppard", Title = "Pour Some Sugar On Me", Bpm = 85, Key = "12A", Intensity = 7, Year = 1987, Disc = "Rock 2", Track = 2, Genre = "Rock"},
                new Song{Artist = "Def Leppard", Title = "Let's Get Rocked (LQ)", Bpm = 92, Key = "4A", Intensity = 7, Year = 1992, Disc = "Rock 2", Track = 3, Genre = "Rock"},
                new Song{Artist = "Bon Jovi", Title = "Lay Your Hands on Me (LQ)", Bpm = 100, Key = "7A", Intensity = 5, Year = 1988, Disc = "Rock 2", Track = 4, Genre = "Rock"},
                new Song{Artist = "INXS", Title = "Need You Tonight (LQ)", Bpm = 109, Key = "5A", Intensity = 6, Year = 1987, Disc = "Rock 2", Track = 5, Genre = "Rock"},
                new Song{Artist = "Nirvana", Title = "Smells Like Teen Spirit (LQ)", Bpm = 117, Key = "4A", Intensity = 6, Year = 1991, Disc = "Rock 2", Track = 6, Genre = "Rock"},
                new Song{Artist = "Midnight Oil", Title = "Beds Are Burning (LQ)", Bpm = 119, Key = "9A", Intensity = 6, Year = 1987, Disc = "Rock 2", Track = 7, Genre = "Rock"},
                new Song{Artist = "Cold Chisel", Title = "Flame Trees", Bpm = 120, Key = "12B", Intensity = 6, Year = 1984, Disc = "Rock 2", Track = 8, Genre = "Rock"},
                new Song{Artist = "Electric Light Orchestra", Title = "Livin' Thing (LQ)", Bpm = 122, Key = "8A", Intensity = 5, Year = 1976, Disc = "Rock 2", Track = 9, Genre = "Rock"},
                new Song{Artist = "Bon Jovi", Title = "Livin' on a Prayer (LQ)", Bpm = 122, Key = "9A", Intensity = 7, Year = 1986, Disc = "Rock 2", Track = 10, Genre = "Rock"},
                new Song{Artist = "Mondo Rock", Title = "Cool World", Bpm = 125, Key = "12B", Intensity = 7, Year = 1981, Disc = "Rock 2", Track = 11, Genre = "Rock"},
                new Song{Artist = "Metallica", Title = "Enter Sandman (LQ)", Bpm = 125, Key = "9A", Intensity = 6, Year = 1991, Disc = "Rock 2", Track = 12, Genre = "Rock"},
                new Song{Artist = "Guns N' Roses", Title = "Sweet Child O' Mine (LQ)", Bpm = 125, Key = "3B_2A", Intensity = 5, Year = 1987, Disc = "Rock 2", Track = 13, Genre = "Rock"},
                new Song{Artist = "Fleetwood Mac", Title = "You Make Loving Fun", Bpm = 127, Key = "6B", Intensity = 5, Year = 1977, Disc = "Rock 2", Track = 14, Genre = "Rock"},
                new Song{Artist = "Neil Diamond", Title = "Sweet Caroline (LQ)", Bpm = 128, Key = "1B", Intensity = 4, Year = 1969, Disc = "Rock 2", Track = 15, Genre = "Rock"},
                new Song{Artist = "New Order", Title = "Blue Monday 88 (LQ)", Bpm = 130, Key = "7A", Intensity = 7, Year = 1983, Disc = "Rock 2", Track = 16, Genre = "Rock"},
                new Song{Artist = "The Angels", Title = "No Secrets", Bpm = 140, Key = "9B", Intensity = 7, Year = 1987, Disc = "Rock 2", Track = 17, Genre = "Rock"},
                new Song{Artist = "The Killers", Title = "Mr Brightside (LQ)", Bpm = 148, Key = "3B", Intensity = 7, Year = 2004, Disc = "Rock 2", Track = 18, Genre = "Rock"},

                // Soul 1
                new Song{Artist = "The Jackson 5", Title = "I Want You Back (LQ)", Bpm = 98, Key = "4B", Intensity = 5, Year = 1969, Disc = "Soul 1", Track = 1, Genre = "Soul"},
                new Song{Artist = "Stevie Wonder", Title = "Superstition", Bpm = 101, Key = "2A", Intensity = 6, Year = 1986, Disc = "Soul 1", Track = 2, Genre = "Soul"},
                new Song{Artist = "Chaka Khan", Title = "Ain't Nobody", Bpm = 104, Key = "2A", Intensity = 7, Year = 1978, Disc = "Soul 1", Track = 3, Genre = "Soul"},
                new Song{Artist = "Andrea True Connection", Title = "More, More, More (LQ)", Bpm = 104, Key = "7A", Intensity = 6, Year = 1976, Disc = "Soul 1", Track = 4, Genre = "Soul"},
                new Song{Artist = "The Whispers", Title = "And the Beat Goes On", Bpm = 114, Key = "10A", Intensity = 7, Year = 1979, Disc = "Soul 1", Track = 5, Genre = "Soul"},
                new Song{Artist = "The Emotions", Title = "Best of My Love", Bpm = 115, Key = "8A", Intensity = 5, Year = 1977, Disc = "Soul 1", Track = 6, Genre = "Soul"},
                new Song{Artist = "Candi Staton", Title = "Young Hearts Run Free (LQ)", Bpm = 115, Key = "7B", Intensity = 6, Year = 1976, Disc = "Soul 1", Track = 7, Genre = "Soul"},
                new Song{Artist = "Sam & Dave", Title = "Soul Man (LQ)", Bpm = 117, Key = "12B", Intensity = 5, Year = 1967, Disc = "Soul 1", Track = 8, Genre = "Soul"},
                new Song{Artist = "LaBelle", Title = "Lady Marmalade (LQ)", Bpm = 117, Key = "6A", Intensity = 6, Year = 1974, Disc = "Soul 1", Track = 9, Genre = "Soul"},
                new Song{Artist = "Marvin Gaye", Title = "Got To Give It Up (LQ)", Bpm = 122, Key = "11B", Intensity = 6, Year = 1977, Disc = "Soul 1", Track = 10, Genre = "Soul"},
                new Song{Artist = "Stevie Wonder", Title = "Higher Ground (LQ)", Bpm = 126, Key = "2A", Intensity = 6, Year = 1973, Disc = "Soul 1", Track = 11, Genre = "Soul"},
                new Song{Artist = "Four Tops", Title = "I Can't Help Myself (Sugar Pie, Honey Bunch)", Bpm = 126, Key = "8B", Intensity = 6, Year = 1965, Disc = "Soul 1", Track = 12, Genre = "Soul"},
                new Song{Artist = "Curtis Mayfield", Title = "Pusherman (LQ)", Bpm = 126, Key = "4A", Intensity = 3, Year = 1988, Disc = "Soul 1", Track = 13, Genre = "Soul"},
                new Song{Artist = "Aretha Franklin", Title = "Freeway Of Love (LQ)", Bpm = 126, Key = "7A", Intensity = 6, Year = 1985, Disc = "Soul 1", Track = 14, Genre = "Soul"},
                new Song{Artist = "Earth, Wind & Fire", Title = "September (LQ)", Bpm = 127, Key = "11B", Intensity = 6, Year = 1971, Disc = "Soul 1", Track = 15, Genre = "Soul"},
                new Song{Artist = "James Brown", Title = "Papa's Got A Brand New Bag (LQ)", Bpm = 130, Key = "9A", Intensity = 4, Year = 1966, Disc = "Soul 1", Track = 16, Genre = "Soul"}
            };

            foreach (Song s in songs)
            {
                var song = context.Songs.SingleOrDefault(m => m.Artist == s.Artist && 
                    m.Title == s.Title &&
                    m.Bpm == s.Bpm &&
                    m.Key == s.Key &&
                    m.Intensity == s.Intensity &&
                    m.Year == s.Year &&
                    m.Disc == s.Disc &&
                    m.Track == s.Track &&
                    m.Genre == s.Genre);

                if (song == null)
                {
                    context.Songs.Add(s);
                }
            }

            context.SaveChanges();
        }
    }
}

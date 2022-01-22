using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class Artist
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? Phone { get; set; }
        public string? Email { get; set; }
        public string? InstagramUrl { get; set; }
        public List<ArtistSong> ArtistSong { get; set; } = new List<ArtistSong>();
    }
}

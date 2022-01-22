using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    public class ArtistSongConfigurations : IEntityTypeConfiguration<ArtistSong>
    {
        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {

            builder
               .HasKey(k => k.Id);
            builder
                .Property(k => k.Id)
                .ValueGeneratedNever();
            builder
                .HasData(
                new ArtistSong { Id = 1, ArtistId = 1, SongId = 3 },
                new ArtistSong { Id = 2, ArtistId = 2, SongId = 2 },
                new ArtistSong { Id = 3, ArtistId = 3, SongId = 1 },
                new ArtistSong { Id = 4, ArtistId = 4, SongId = 4 },
                new ArtistSong { Id = 5, ArtistId = 5, SongId = 5 },
                new ArtistSong { Id = 6, ArtistId = 2, SongId = 4 });
        }
    }
}

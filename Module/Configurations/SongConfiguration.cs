using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module
{
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder
                .HasKey(k => k.SongId);
            builder
                .Property(k => k.SongId)
                .ValueGeneratedNever();
            builder
                .Property(k => k.Duration)
                .IsRequired()
                .HasMaxLength(10);
            builder
                .Property(k => k.ReleasedDate)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .Property(k => k.Title)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .HasData(new Song
                { SongId = 1, Title = "Единственная моя", Duration = 4.44d, GenreId = 1, ReleasedDate = new DateTime(1998, 4, 11)},
                new Song
                { SongId = 2, Title = "Without Me", Duration = 5.13d, GenreId = 2, ReleasedDate = new DateTime(2009, 06, 16) },
                 new Song
                 { SongId = 3, Title = "Positions", Duration = 2.58d, GenreId = 1, ReleasedDate = new DateTime(2020, 10, 23) },
                 new Song
                 { SongId = 4, Title = "Love The Way You Lie", Duration = 5.07d, GenreId = 1, ReleasedDate = new DateTime(2010, 5, 8) },
                 new Song
                 { SongId = 5, Title = "Все как у людей", Duration = 4.17d, GenreId = 3, ReleasedDate = new DateTime(2019, 9, 10) });
        }
    }
}

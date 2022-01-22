using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Module
{
    class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder
                .HasKey(k => k.ArtistId);
            builder
                .Property(k => k.ArtistId)
                .ValueGeneratedNever();
            builder
                .Property(k => k.Name)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .Property(k => k.DateOfBirth)
                .IsRequired()
                .HasMaxLength(255);
            builder
                .HasData(new Artist
                { ArtistId = 1, DateOfBirth = new DateTime(2000, 6, 26), Name = "Ariana Grande" },
                new Artist
                { ArtistId = 2, DateOfBirth = new DateTime(1972, 10, 17), Name = "Eminem" },
                 new Artist
                 { ArtistId = 3, DateOfBirth = new DateTime(1967, 4, 30), Name = "Fillip Kirkorov" },
                new Artist
                { ArtistId = 4, DateOfBirth = new DateTime(1988, 2, 20), Name = "Rihanna" },
                new Artist
                { ArtistId = 5, DateOfBirth = new DateTime(1985, 3, 9), Name = "NoizeMc" });
        }
    }
}

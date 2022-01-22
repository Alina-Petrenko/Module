using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
    class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder
               .HasKey(k => k.GenreId);
            builder
                .Property(k => k.GenreId)
                .ValueGeneratedNever();
            builder
                .HasData(new Genre
                { GenreId = 1, Title = "Pop" },
                new Genre
                { GenreId = 2, Title = "Rap" },
                new Genre
                { GenreId = 3, Title = "Rock" });

        }
    }
}

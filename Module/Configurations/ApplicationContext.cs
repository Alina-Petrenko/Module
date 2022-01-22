using Microsoft.EntityFrameworkCore;

namespace Module
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<ArtistSong> ArtistsSongs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SongConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new ArtistSongConfigurations());
        }
    }
}
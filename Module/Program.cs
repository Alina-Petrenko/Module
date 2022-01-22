using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Module
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                var innerJoin = (from artistSong in context.ArtistsSongs
                                join artist in context.Artists on artistSong.ArtistId equals artist.ArtistId
                                join song in context.Songs on artistSong.SongId equals song.SongId
                                join genre in context.Genres on song.GenreId equals genre.GenreId
                                select new
                                {
                                    Title = song.Title,
                                    Name = artist.Name,
                                    Genre = song.Genre
                                }).ToSql();
                Console.WriteLine(innerJoin);
                Console.WriteLine("");
                var group = context.Songs.GroupBy(g => g.GenreId).Select(g => new
                {
                    Genre = g.Key,
                    Count = g.Count()
                }).ToSql();
                Console.WriteLine(group);
                Console.WriteLine("");
                var songs = context.Songs.Where(k => k.ReleasedDate < context.Artists.Max(k => k.DateOfBirth)).ToSql();
                Console.WriteLine(songs);
            }
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MovieList.Db.Models;

namespace MovieList.Db
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options) { }

        public DbSet<Movie> Movies { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                 new Movie
                 {
                     MovieID = 1,
                     Name="Casablanca",
                     Year=1942,
                     Rating=5,
                     GenreID="D"
                 },
                 new Movie
                 {
                     MovieID=2,
                     Name="Wonder Woman",
                     Year=2017,
                     Rating=3,
                     GenreID="A"
                 },
                 new Movie
                 {
                     MovieID=3,
                     Name="Moonstruck",
                     Year=1988,
                     Rating=4,
                     GenreID="R"
                 }
            );

            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreID="A", Name="Action"},
                new Genre { GenreID = "C", Name = "Comedy" },
                new Genre { GenreID = "D", Name = "Drama" },
                new Genre { GenreID = "H", Name = "Horror" },
                new Genre { GenreID = "M", Name = "Musical" },
                new Genre { GenreID = "R", Name = "Romantical Comedy" },
                new Genre { GenreID = "S", Name = "Sci-Fi" }
            );
        }
    }

}

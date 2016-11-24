using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace HelloWorld.Models
{
    public class Movie
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public DateTime ReleaseDate { set; get; }
        public string Genre { set; get; }
        public decimal Price { set; get; }
    }
    public class MovieDBContext : DbContext
    {
    public DbSet<Movie> Movies { set; get; }
    }
}
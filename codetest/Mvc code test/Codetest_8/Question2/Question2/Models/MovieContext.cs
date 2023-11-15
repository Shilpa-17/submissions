using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Question2.Models
{
    public class MovieContext: DbContext
    {
        public MovieContext() : base("name=connectstr")
        { }
        public DbSet<Movie> Movies { get; set; }
    }
}
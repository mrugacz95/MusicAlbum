using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicAlbum.Models
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext() : base("DefaultConnection") { }
        public DbSet<Song> Songs { get; set; }

        public System.Data.Entity.DbSet<MusicAlbum.Models.Genre> Genres { get; set; }
    }
}
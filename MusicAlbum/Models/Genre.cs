using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicAlbum.Models
{
    public class Genre
    {
        [Key]
        public int GenresId { get; set; }
        [Display]
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
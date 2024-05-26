using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("SongType")]
    public class SongType
    {
        [Key]
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Song> Song { get; set; } = null!;
        public ICollection<PlaylistSynthetic> PlaylistSynthetic { get; set; } = null!;
      
    }
}

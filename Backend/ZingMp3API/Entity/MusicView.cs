using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("MusicView")]
    public class MusicView
    {

        [Key]
        [Required]
        public string SongId { get; set; }
        [ForeignKey("SongId")]
        public virtual Song Song { get; set; }

        public int CountView { get; set; }
    }
}

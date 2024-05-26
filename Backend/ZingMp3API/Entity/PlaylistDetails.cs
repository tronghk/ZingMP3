using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("PlaylistDetails")]
    public class PlaylistDetails
    {
        public string PlaylistSingerId
        { get; set; }
        
        public string SongId
        { get; set;}
        [ForeignKey("SongId")]
        public virtual Song Song { get; set; }  
    }
}

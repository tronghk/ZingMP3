using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("Favorite")]
    public class Favorite
    {
        
        public string UserId { get; set; }
        public string SongId { get; set; }
    }
}

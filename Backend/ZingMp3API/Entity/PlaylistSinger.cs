using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("PlaylistSinger")]
    public class PlaylistSinger
    {
       
        [Key]
        [Required]
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserInfor UserInfor { get; set; }
    }
}

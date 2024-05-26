using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("PlaylistSynthetic")]
    public class PlaylistSynthetic
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string TypeId
           

        { get; set; }
        [ForeignKey("TypeId")]
        public virtual SongType SongType { get; set; }
        [Required]
        public string SingerId { get; set; }
        [ForeignKey("SingerId")]
        public virtual UserInfor UserInfor { get; set; }

    }
}

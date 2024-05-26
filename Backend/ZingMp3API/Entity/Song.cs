using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("Song")]
    public class Song
    {
        [Key]
        [Required]

        public string Id { get; set; }
        [Required]
        public string Filename { get; set; }
        [Required]
        public string SongTypeId { get; set; }
        [ForeignKey("IdSongType")]
        public virtual SongType SongType { get; set; }

       
        [Required]
        public string TimeMax
        { get; set; }
        [Required]
        public string Name
        { get; set; }
        [Required]
        public string UserId
        { get; set; }
        [ForeignKey("UserId")]
        public virtual UserInfor UserInfor { get; set; }
        [Required]
        public string Img
        { get; set; }
        [Required]
        public string DateCreate
        { get; set; }
        [Required]
        public string PublisherId
        { get; set; }
        [ForeignKey("PublisherId")]
        public virtual Publisher Publisher { get; set; }

        public ICollection<PlaylistDetails> PlaylistDetails { get; set;}
        public ICollection<MusicView> MusicViews { get; set; }
             public ICollection<TimeListen> TimeListens { get; set; }
    }
}

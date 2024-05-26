using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("UserInfor")]
    public class UserInfor
    {
        [Key]
        [Required]
        public string Id { get; set; }
        [Required]
        public string FirstName
            { get; set; }
        [Required]
        public string Image
        { get; set; }
        [Required]
        public string LastName
        { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        = string.Empty;
        public ICollection<Song> Song { get; set; } = null!;
        public ICollection<PlaylistSinger> PlaylistSinger { get; set; } = null!;

        public ICollection<PlaylistSynthetic> PlaylistSynthetics { get; set; } = null!;
        public ICollection<PlaylistUser> PlaylistUsers { get; set; } = null!;

        public ICollection<ListenRecently> ListenRecentlies { get; set; } = null!;

    }
}

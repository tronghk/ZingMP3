using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("ListenRecently")]
    public class ListenRecently
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string UserId { get; set; }
       

        [ForeignKey("UserId")]
        public virtual UserInfor UserInfor { get; set; }

        [Required]
        public int type { get; set; }
    }
}

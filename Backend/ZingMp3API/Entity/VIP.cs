using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("VIP")]
    public class VIP
    {
        [Key]
        [Required]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual UserInfor UserInfor { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
    }
}

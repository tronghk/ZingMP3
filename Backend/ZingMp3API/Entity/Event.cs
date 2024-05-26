using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("Event")]
    public class Event
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public DateTime TimeCreate { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int CareView { get; set; }


    }
}

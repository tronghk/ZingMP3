using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("TimeListen")]
    public class TimeListen
    {
        public DateTime Time {  get; set; }
        public string SongId { get; set; }
        [ForeignKey("SongId")]
        public virtual Song Song { get; set; }  
        public int count { get; set; }

    }
}

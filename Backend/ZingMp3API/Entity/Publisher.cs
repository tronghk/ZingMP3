using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZingMp3API.Entity
{
    [Table("Publisher")]
    public class Publisher
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public ICollection<Song> Songs { get; set; }

    }
}

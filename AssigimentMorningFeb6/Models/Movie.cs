using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssigimentMorningFeb6.Models
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Mid { get; set; }
        public string MName { get; set; }
        public string StarCast { get; set; }
        public string Director { get; set; }
    }
}

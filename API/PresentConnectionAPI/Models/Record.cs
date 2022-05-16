using System.ComponentModel.DataAnnotations;

namespace PresentConnectionAPI.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Body { get; set; }
    }
}

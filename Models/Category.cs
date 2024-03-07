using System.ComponentModel.DataAnnotations;

namespace WebNetAlex.Models
{
    public class Category
    {
        [Key]
        public int Category21Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace AbbyRazer.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}

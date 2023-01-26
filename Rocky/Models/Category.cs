using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }
        [DisplayName("Display order")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше 0")]
        public int DisplayOrder { get; set; }
    }
}

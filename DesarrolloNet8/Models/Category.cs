using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesarrolloNet8.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category name")]
        public string Name { get; set; }

        [DisplayName("Display order")]
        [Range(1,100, ErrorMessage = "Display order must be a value between 1 and 100")]
        public int displayOrder { get; set; }
    }
}

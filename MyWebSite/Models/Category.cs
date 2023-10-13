using System.ComponentModel.DataAnnotations;

namespace MyWebSite.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [StringLength(20)]
        [Required]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }

       
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Models
{
    public class Product
    { 

        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string ProductName { get; set; } = "";
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public int ProductPrice { get; set; }


    }
}

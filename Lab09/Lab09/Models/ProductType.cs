using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09.Models
{
    [Table("PRODUCT_TYPE")]
    public class ProductType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public ProductType()
        {
            Products = new HashSet<Product>();
        }
    }
}

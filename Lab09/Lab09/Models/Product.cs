using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09.Models
{
    [Table("PRODUCT")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductId { get; set; }

        [Required]  
        [StringLength(255)]
        public string ProductName { get; set; }

        [StringLength(500)]
        public string PictureUrl { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public bool Status { get; set; }

        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public virtual ProductType ProductType { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }
    }
}

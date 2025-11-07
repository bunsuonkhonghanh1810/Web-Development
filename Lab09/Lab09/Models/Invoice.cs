using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09.Models
{
    [Table("INVOICE")]
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceId { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        [StringLength(255)]
        public string DateReceived { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(15)]
        public string CustomerPhone { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerAddress { get; set; }

        [Column(TypeName = "money")]
        public decimal Total { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Invoice()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace Lab09.Models
{
    public class Lab09DbContext : DbContext
    {
        public Lab09DbContext(DbContextOptions<Lab09DbContext> options):base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

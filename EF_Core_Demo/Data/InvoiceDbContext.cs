
using Microsoft.EntityFrameworkCore;
using EF_Core_Demo.Models;

namespace EF_Core_Demo.Data;

// Used to represent the Invoice database.
public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options) : DbContext(options)
{
    // Used to represent the Invoices table in the database.
    public DbSet<Invoice> Invoices => Set<Invoice>();
}

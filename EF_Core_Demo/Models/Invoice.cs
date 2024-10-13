
namespace EF_Core_Demo.Models;

public class Invoice
{
    /*Guid is unique no matter how many databases you have, but it is more expensive to store,
    insert, query, and sort the records than using int or long.
    */
    public Guid Id { get; set; }
    public string InvoiceNumber { get; set; } = string.Empty;
    public string ContactName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Amount { get; set; }
    /*
    We use the DateTimeOffset type for the InvoiceDate and DueDate properties,
    which is the recommended type for date and time in .NET Core. You can also use the DateTime
    type if you do not care about the time zone. DateTimeOffset includes a time zone offset
    from UTC time, and it is supported by both .NET type and SQL Server. This is helpful if you
    want to avoid the time zone issues.
    */
    public DateTimeOffset InvoiceDate { get; set; }
    public DateTimeOffset DueDate { get; set; }
    public InvoiceStatus Status { get; set; }
}

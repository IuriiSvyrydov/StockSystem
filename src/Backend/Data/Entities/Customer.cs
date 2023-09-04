using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Customers", Schema = "dbo")]
public class Customer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CustId { get; set; }
    public string? FullNameUA { get; set; }
    public string? FullNameUS { get; set; }

    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public City City { get; set; }
}
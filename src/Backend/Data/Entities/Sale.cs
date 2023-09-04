using Data.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data;

[Table("Sales", Schema = "dbo")]
public class Sale
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int SaleId { get; set; }
    public Product? ProductId { get; set; }
    public Customer? CustomerId { get; set; }
    public DateTime Create { get; set; }
    public int Quantity { get; set; }
    public Employee? PersonId { get; set; }
}
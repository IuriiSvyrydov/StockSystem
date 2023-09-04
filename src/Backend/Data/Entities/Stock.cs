using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("Stocks", Schema = "dbo")]
public class Stock
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public Product? ProductId { get; set; }
    public Employee? EmpId { get; set; }
    public DateTime Create { get; set; }
    public int Quantity { get; set; }
}
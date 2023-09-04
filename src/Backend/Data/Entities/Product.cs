using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Products", Schema = "dbo")]

public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProdId { get; set; }
    public string? NameUa { get; set; }
    public string? NameUs { get; set; }
    public DateTime Created { get; set; }
    public Category? CatId { get; set; }
    public decimal Price { get; set; }
}
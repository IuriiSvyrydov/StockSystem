using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("Cities", Schema = "dbo")]
public class City
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CityId { get; set; }
    public string? NameUA { get; set; }
    public string? NameUS { get; set; }
    public int? CustomerId { get; set; }
    [ForeignKey("CustomerId")]
    [InverseProperty("City")]
    public Customer? Customer { get; set; }

    public int? ParentId { get; set; }

}
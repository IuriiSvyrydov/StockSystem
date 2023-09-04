using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;
[Table("Powers", Schema = "dbo")]
public class Power
{
    public int PowerId { get; set; }
    public string Name { get; set; }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities;

[Table("UserPrivileges", Schema = "dbo")]
public class User_Privileges
{
    public int Id { get; set; }
    public Power? PowerId { get; set; }
    public int? PersonId { get; set; }
    public string Password { get; set; }
}
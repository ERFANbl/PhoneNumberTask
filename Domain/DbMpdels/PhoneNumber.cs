using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DbMpdels;

[Table("TASK_PhoneNumber")]
public class UserPhoneNumber
{
    public int Id { get; set; }
    public string PhoneNumber { get; set; }
}

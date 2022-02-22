using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("User")]
public class UserEntity
{
    [MaxLength(50)]
    public string Nombre { get; set; }
    [MaxLength(50)]
    public string Apellido { get; set; }
    [MaxLength(50)]
    public string Nacionalidad { get; set; }
    public DateTime? FechNac { get; set; }
    public int Id { get; set; }
}
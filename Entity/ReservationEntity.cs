using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Reservation")]
public class ReservationEntity
{
    public UserEntity User { get; set; }
    public BookEntity Book { get; set; }
    public int Id { get; set; }
}

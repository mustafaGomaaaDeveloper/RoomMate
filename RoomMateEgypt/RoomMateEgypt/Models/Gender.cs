using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("Gender", Schema = ("dbo"))]
    public class Gender
    {
        [Key]
        public short GenderId { get; set; }
        public string GenderName { get; set; }
    }
}

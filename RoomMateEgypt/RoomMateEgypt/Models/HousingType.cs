using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("HousingType", Schema = ("dbo"))]
    public class HousingType
    {
        [Key]
        public short HousingTypeId { get; set; }
        public string HousingTypeName { get; set; }
    }
}

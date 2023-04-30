using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("RoomType", Schema = ("dbo"))]
    public class RoomType
    {
        [Key]
        public short TypeId { get; set; }
        public string TypeName { get; set; }
    }
}

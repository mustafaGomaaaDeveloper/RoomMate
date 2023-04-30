using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("RoomImage", Schema = ("dbo"))]
    public class RoomImage
    {
        [Key]
        public long ImageId { get; set; }
        public string ImagePath { get; set; }
        public long RoomId { get; set; }
        public string? ImageDescription { get; set; }
    }
}

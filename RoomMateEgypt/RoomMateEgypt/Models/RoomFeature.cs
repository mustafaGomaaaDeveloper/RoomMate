using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("RoomFeature", Schema = ("dbo"))]
    public class RoomFeature
    {
        [Key]
        public long RoomFeatureId { get; set; }
        public long RoomId { get; set; }
        public short FeatureId { get; set; }
    }
}

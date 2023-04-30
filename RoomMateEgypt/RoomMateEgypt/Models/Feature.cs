using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("Feature", Schema = ("dbo"))]
    public class Feature
    {
        [Key]
        public short FeatureId { get; set; }
        public string FeatureName { get; set; }
    }
}

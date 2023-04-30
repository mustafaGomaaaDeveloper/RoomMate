using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("PeriodOfAvailability", Schema = ("dbo"))]
    public class PeriodOfAvailability
    {
        [Key]
        public short PeriodOfAvailabilityId { get; set; }
        public string Availability { get; set; }

    }
}

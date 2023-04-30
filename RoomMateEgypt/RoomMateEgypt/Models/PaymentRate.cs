using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("PaymentRate", Schema = ("dbo"))]
    public class PaymentRate
    {
        [Key]
        public short PaymentRateID { get; set; }
        public string PaymentRateName { get; set; }
    }
}

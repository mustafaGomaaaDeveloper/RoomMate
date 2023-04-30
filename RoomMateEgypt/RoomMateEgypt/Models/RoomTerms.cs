using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("RoomTerms", Schema = ("dbo"))]
    public class RoomTerms
    {
        [Key]
        public long RoomTermsId { get; set; }
        public long RoomId { get; set; }
        public short TermsId { get; set; }

    }
}

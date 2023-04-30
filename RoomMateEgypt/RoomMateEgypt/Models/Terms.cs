using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("Terms", Schema = ("dbo"))]
    public class Terms
    {
        [Key]
        public short TermsId { get; set; }
        public string TermsName { get; set; }
    }
}

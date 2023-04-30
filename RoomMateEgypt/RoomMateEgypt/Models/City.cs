using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
    [Table("City", Schema = ("dbo"))]
    public class City
    {
        [Key]
        public int CItyId { get; set; }
        public string CityName { get; set; }
    }
}

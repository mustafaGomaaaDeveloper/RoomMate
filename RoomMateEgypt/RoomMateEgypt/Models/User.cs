using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
	[Table("User", Schema = ("dbo"))]
	public class User
    {
		[Key]
		public long UserId { get; set; }
		public string UserName { get; set; }
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? HashingPassword { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RoomMateEgypt.Models
{
	[Table("Room", Schema = ("dbo"))]
	public class Room
    {
		[Key]
		public long RoomId { get; set; }
		public short RoomTypeId { get; set; }
		public decimal? Price { get; set; }
		public short GenderId { get; set; }
		public decimal? Insurance { get; set; }
		public decimal? DownPayment { get; set; }
		public bool? Furnished { get; set; }
        
		public DateTime DateTime{get;set;} //need dataanotaion column DateTime
		public short HousingTypeId { get; set; }
		public int? LocationId { get; set; }
		public long UserId { get; set; }
		public string Address { get; set; }
		public string? Description { get; set; }
		public short PersonsCapacity { get; set; }
		public short PeriodOfAvailabilityId { get; set; }
		public short PaymentRateId { get; set; }
		public string? AvailabilityDetails { get; set; }
		public bool IsDeleted { get; set; }
	
	}
}

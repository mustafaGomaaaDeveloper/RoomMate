using Microsoft.EntityFrameworkCore;

namespace RoomMateEgypt.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) { }

        protected AppDBContext()
        {
        }

        public virtual DbSet<City>? Cities{ get; set; }
        public virtual DbSet<District>? Districts{ get; set; }
        public virtual DbSet<Feature>? Features{ get; set; }
        public virtual DbSet<Gender>? Genders{ get; set; }
        public virtual DbSet<HousingType>? HousingTypes{ get; set; }
        public virtual DbSet<PaymentRate>? PaymentRates{ get; set; }
        public virtual DbSet<PeriodOfAvailability>? PeriodOfAvailabilities{ get; set; }
        public virtual DbSet<Room>? Rooms{ get; set; }
        public virtual DbSet<RoomFeature>? RoomFeatures{ get; set; }
        public virtual DbSet<RoomImage>? RoomImages{ get; set; }
        public virtual DbSet<RoomTerms>? RoomTerms{ get; set; }
        public virtual DbSet<RoomType>?  RoomTypes{ get; set; }
        public virtual DbSet<Terms>?  Terms{ get; set; }
        public virtual DbSet<User>?  Users{ get; set; }
      

    }
}

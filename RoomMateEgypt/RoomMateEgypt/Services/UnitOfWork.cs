using AutoMapper;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;

       
        public IRoom Room{ get; set; }
        public ICity City{ get; set; }
        public IDistrict District{ get; set; }
        public IFeature Feature{ get; set; }
        public IUser User{ get; set; }
        public IHousingType HousingType{ get; set; }
        public IPaymentRate PaymentRate { get; set; }
        public ITerms Terms { get; set; }
        public IPeriodOfAvailability PeriodOfAvailability { get; set; }
        

        public UnitOfWork(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            Room = new RoomRepo(this, _context, _mapper);
            City = new CityRepo(this, _context, _mapper);
            District = new DistrictRepo(this, _context, _mapper);
            Feature = new FeatureRepo(this, _context, _mapper);
            User = new UserRepo(this, _context, _mapper);
            HousingType = new HousingTypeRepo(this, _context, _mapper);
            PaymentRate = new PaymentRateRepo(this, _context, _mapper);
            Terms = new TermsRepo(this, _context, _mapper);
            PeriodOfAvailability=new PeriodOfAvailabilityRepo(this, _context, _mapper); 
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class PeriodOfAvailabilityRepo : Base<PeriodOfAvailability>, IPeriodOfAvailability
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public PeriodOfAvailabilityRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<IEnumerable<PeriodOfAvailability>> GetPeriodOfAvailability()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                return new GenericResponse<IEnumerable<PeriodOfAvailability>>() { ResponseText = "Cant Get Period Of Availability", Status = EnumStatus.Fail };
            }
        }
    }
}

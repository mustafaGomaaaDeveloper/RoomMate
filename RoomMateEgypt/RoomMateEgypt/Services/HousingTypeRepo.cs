using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class HousingTypeRepo : Base<HousingType>, IHousingType
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public HousingTypeRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<IEnumerable<HousingType>> GetHousingType()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                return new GenericResponse<IEnumerable<HousingType>>() { ResponseText = "Cant Get Housing Type", Status = EnumStatus.Fail };
            }
        ;
        }
    }
}

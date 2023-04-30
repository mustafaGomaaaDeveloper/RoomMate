using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class DistrictRepo : Base<District>, IDistrict
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public DistrictRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<District> GetDistrictById(int districtId)
        {
            try
            {
                return base.GetById(districtId);
            }
            catch
            {
                return new GenericResponse<District>() { ResponseText = "Cant Get District", Status = EnumStatus.Fail };
            }
         ;
        }

        public GenericResponse<List<District>> GetDistrictsByCityId(int cityId)
        {
            try
            {
                return base.FindAll(d=>d.CityId==cityId);
            }
            catch 
            {
                return new GenericResponse<List<District>>() { ResponseText = "Cant Get Districts", Status = EnumStatus.Fail };
            }
        ;
        }
    }
}

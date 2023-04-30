using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class CityRepo : Base<City>, ICity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public CityRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<IEnumerable<City>> GetCities()
        {
            try
            {
                return GetAll();
            }
            catch (Exception ex)
            {
                return new GenericResponse<IEnumerable<City>>() { ResponseText = "Cant Get Cities", Status = EnumStatus.Fail };
            }
           ;
        }
        public GenericResponse<City> GetCityById(int cityId)
        {
            try
            {
                return base.GetById(cityId);
            }
            catch (Exception ex)
            {
                return new GenericResponse<City>() { ResponseText = "Cant Get City", Status = EnumStatus.Fail };
            }
          ;
        }
       
    }
}

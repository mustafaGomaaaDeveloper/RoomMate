using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [Route("HousingType")]
        [HttpGet]
        public GenericResponse<IEnumerable<HousingType>> GetHousingType()
        {
            try
            {
                return _unitOfWork.HousingType.GetHousingType();
            }
            catch 
            {
                return new GenericResponse<IEnumerable<HousingType>>();
            }
        }

        [Route("PeriodOfAvailability")]
        [HttpGet]
        public GenericResponse<IEnumerable<PeriodOfAvailability>> GetPeriodOfAvailability()
        {
            try
            {
                return _unitOfWork.PeriodOfAvailability.GetPeriodOfAvailability();
            }
            catch
            {
                return new GenericResponse<IEnumerable<PeriodOfAvailability>>();
            }
        }

        [Route("RoomTypies")]
        [HttpGet]
        public List<RoomType> GetRoomTypies()
        {
            try
            {
                return _unitOfWork.Room.GetRoomTypies();
            }
            catch 
            {
                return new List<RoomType>();
            }
        }

        [Route("RoomTerms")]
        [HttpGet]
        public GenericResponse<IEnumerable<Terms>> GetTerms()
        {
            try
            {
                return _unitOfWork.Terms.GetTerms();
            }
            catch
            {
                return new GenericResponse<IEnumerable< Terms>>();
            }
        }

    }
}

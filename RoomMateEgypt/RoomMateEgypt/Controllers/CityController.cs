using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public CityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //[Route("Cities")]
        //[HttpGet]
        //public GenericResponse<IEnumerable<City>> GetCities()
        //{
        //    try
        //    {
        //        return _unitOfWork.City.GetCities();
        //    }
        //    catch (Exception ex)
        //    {
        //        return new GenericResponse<IEnumerable<City>>();
        //    }
        //}

        //[Route("City")]
        //[HttpGet]
        //public GenericResponse<City> GetCity(int cityId)
        //{
        //    try
        //    {
        //        return _unitOfWork.City.GetCityById(cityId);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new GenericResponse<City>();
        //    }
        //}


        //[Route("District")]
        //[HttpGet]
        //public GenericResponse<District> GetDistrict(int districtId)
        //{
        //    try
        //    {
        //        return _unitOfWork.District.GetDistrictById(districtId);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new GenericResponse<District>();
        //    }
        //}


        [Route("Districts")]
        [HttpGet]
        public GenericResponse<List<District>> GetDistricts(int cityId)
        {
            try
            {
                return _unitOfWork.District.GetDistrictsByCityId(cityId);
            }
            catch (Exception ex)
            {
                return new GenericResponse<List<District>>();
            }
        }
    }
}

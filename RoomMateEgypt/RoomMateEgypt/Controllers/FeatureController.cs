using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public FeatureController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("Features")]
        [HttpGet]
        public GenericResponse<IEnumerable<Feature>> GetFeatures()
        {
            try
            {
                return _unitOfWork.Feature.GetFeatures();
            }
            catch 
            {
                return new GenericResponse<IEnumerable<Feature>>();
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("GetSex")]
        [HttpGet]
        public List<Gender> GetSexs()
        {
            try
            {
                return _unitOfWork.User.GetSex();
            }
            catch (Exception ex)
            {
                return new List<Gender>();
            }
        }
    }
}

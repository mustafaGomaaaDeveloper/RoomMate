using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [Route("PaymentRate")]
        [HttpGet]
        public GenericResponse<IEnumerable<PaymentRate>> GetPaymentRate()
        {
            try
            {
                return _unitOfWork.PaymentRate.GetPaymentRate();
            }
            catch
            {
                return new GenericResponse<IEnumerable<PaymentRate>>();
            }
        }
    }
}

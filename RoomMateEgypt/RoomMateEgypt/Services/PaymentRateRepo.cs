using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class PaymentRateRepo : Base<PaymentRate>, IPaymentRate
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public PaymentRateRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }
        public GenericResponse<IEnumerable<PaymentRate>> GetPaymentRate()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                return new GenericResponse<IEnumerable<PaymentRate>>() { ResponseText = "Cant Get Payment Rate", Status = EnumStatus.Fail };
            }
       ;
        }
    }
}

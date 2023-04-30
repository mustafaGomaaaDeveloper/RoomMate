using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IPaymentRate : IBase<PaymentRate>
    {
        GenericResponse<IEnumerable<PaymentRate>> GetPaymentRate();
    }
}

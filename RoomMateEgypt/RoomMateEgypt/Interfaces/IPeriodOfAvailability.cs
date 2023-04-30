using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IPeriodOfAvailability : IBase<PeriodOfAvailability>
    {
        GenericResponse<IEnumerable<PeriodOfAvailability>> GetPeriodOfAvailability();
    }
}

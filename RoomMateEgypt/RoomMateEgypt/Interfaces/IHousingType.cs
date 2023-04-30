using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IHousingType : IBase<HousingType>
    {
        GenericResponse<IEnumerable<HousingType>> GetHousingType();
    }
}

using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IDistrict : IBase<District>
    {
        GenericResponse<District> GetDistrictById(int districtId);
        GenericResponse<List<District>> GetDistrictsByCityId(int cityId);
    }
}

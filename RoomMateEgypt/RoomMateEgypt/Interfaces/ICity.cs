using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface ICity : IBase<City>
    {
        GenericResponse<IEnumerable<City>> GetCities();
        GenericResponse<City> GetCityById(int cityId);
    }
}

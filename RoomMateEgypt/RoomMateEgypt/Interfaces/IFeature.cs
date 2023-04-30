using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IFeature : IBase<Feature>
    {
        GenericResponse<IEnumerable<Feature>> GetFeatures();
    }
}

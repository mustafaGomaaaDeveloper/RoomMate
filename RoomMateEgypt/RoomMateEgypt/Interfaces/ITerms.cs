using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface ITerms : IBase<Terms>
    {
        GenericResponse<IEnumerable<Terms>> GetTerms();
    }
}

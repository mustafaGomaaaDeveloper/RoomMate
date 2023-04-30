using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IUser : IBase<User>
    {
        List<Gender> GetSex();
    }
}

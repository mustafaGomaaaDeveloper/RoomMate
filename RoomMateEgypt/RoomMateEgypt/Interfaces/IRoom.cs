using RoomMateEgypt.Models;

namespace RoomMateEgypt.Interfaces
{
    public interface IRoom : IBase<Room>
    {
        List<RoomType> GetRoomTypies();
    }
}

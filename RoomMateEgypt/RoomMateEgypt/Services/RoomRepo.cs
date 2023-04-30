using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.DTOs;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class RoomRepo : Base<Room>, IRoom
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public RoomRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public List<RoomType> GetRoomTypies()
        {
            try
            {
                return _context.RoomTypes!.ToList();
            }
            catch
            {
                return new List<RoomType>();
            }
          ;
        }
        public GenericResponse<IEnumerable<Room>> GetRooms()
        {
            try
            {
                return GetAll();
            }
            catch 
            {
                return new GenericResponse<IEnumerable<Room>>() { ResponseText = "Cant Get Rooms", Status = EnumStatus.Fail };
            }
        }

        //public GenericResponse<IEnumerable<Room>> InsertRoom(RoomRequest room)
        //{
        //    try
        //    {
        //        base.Insert();
        //        //return Insert(room);
        //    }
        //    catch
        //    {
        //        return new GenericResponse<IEnumerable<Room>>() { ResponseText = "Cant Get Rooms", Status = EnumStatus.Fail };
        //    }
        //}

    }
}

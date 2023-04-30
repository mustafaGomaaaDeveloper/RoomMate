using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class UserRepo : Base<User>, IUser
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public UserRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public List<Gender> GetSex()
        {
            try
            {
                return _context.Genders!.ToList() ;
            }
            catch
            {
                return new List<Gender>();
            }
        }
    }
}

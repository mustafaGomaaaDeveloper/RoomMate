using AutoMapper;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class GenderRepo : Base<Gender>, IGender
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public GenderRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }
    }
}

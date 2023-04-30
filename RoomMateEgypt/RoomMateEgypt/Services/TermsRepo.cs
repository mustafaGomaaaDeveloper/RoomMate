using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class TermsRepo : Base<Terms>, ITerms
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public TermsRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<IEnumerable<Terms>> GetTerms()
        {
            try
            {
                return GetAll();
            }
            catch 
            {
                return new GenericResponse<IEnumerable<Terms>>() { ResponseText = "Cant Get Terms", Status = EnumStatus.Fail };
            }
          ;
        }
    }
}

using AutoMapper;
using PremiumMainCS.GenericResponse;
using RoomMateEgypt.Interfaces;
using RoomMateEgypt.Models;

namespace RoomMateEgypt.Services
{
    public class FeatureRepo : Base<Feature>, IFeature
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDBContext _context;
        public readonly IMapper _mapper;
        public FeatureRepo(IUnitOfWork unitOfWork, AppDBContext context, IMapper mapper) : base(context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public GenericResponse<IEnumerable<Feature>> GetFeatures()
        {
            try
            {
                return base.GetAll();
            }
            catch
            {
                return new GenericResponse<IEnumerable<Feature>>() { ResponseText = "Cant Get Fetures", Status = EnumStatus.Fail };
            }
        }
    }
}

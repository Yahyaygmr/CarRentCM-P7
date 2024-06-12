using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, List<GetCarQueryResult>>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;

        public GetCarQueryHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<GetCarQueryResult>> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var values = _context.Cars.ToList();

            return _mapper.Map<List<GetCarQueryResult>>(values);
        }
    }
}

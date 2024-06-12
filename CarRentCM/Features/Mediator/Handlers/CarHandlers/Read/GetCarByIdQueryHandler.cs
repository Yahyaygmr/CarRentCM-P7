using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;
        public GetCarByIdQueryHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            var values = _context.Cars.Find(request.Id);

            var result =  _mapper.Map<GetCarByIdQueryResult>(values);

            return Task.FromResult(result);
        }
    }
}

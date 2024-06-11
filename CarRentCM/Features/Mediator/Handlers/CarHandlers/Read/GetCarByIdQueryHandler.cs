using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetCarByIdQueryHandler : IRequestHandler<GetCarByIdQuery, GetCarByIdQueryResult>
    {
        public Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

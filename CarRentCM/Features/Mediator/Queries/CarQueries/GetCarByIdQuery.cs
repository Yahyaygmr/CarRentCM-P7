using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;

namespace CarRentCM.Features.Mediator.Queries.CarQueries
{
    public class GetCarByIdQuery : IRequest<GetCarByIdQueryResult>
    {
        public int Id { get; set; }

        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetCarsWithySerachParametersQueryHandler : IRequestHandler<GetCarsWithySerachParametersQuery, List<GetCarsWithySerachParametersQueryResult>>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;

        public GetCarsWithySerachParametersQueryHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<GetCarsWithySerachParametersQueryResult>> Handle(GetCarsWithySerachParametersQuery request, CancellationToken cancellationToken)
        {
            var values = _context.Cars
                .Include(x => x.BodyType)
                .Include(x => x.Brand)
                .Include(x => x.Location)
                .Where(x => x.BodyTypeId == request.BodyType && x.LocationId == request.PickUpLocation)
                .ToList();
            var result = values.Select(x => new GetCarsWithySerachParametersQueryResult
            {
                BrandName = x.Brand.Name,
                CarId = x.CarId,
                Description = x.Description,
                Door = x.Door,
                Fuel = x.Fuel,
                ImageUrl = x.ImageUrl,
                Km = x.Km,
                Luggage = x.Luggage,
                ModelName = x.ModelName,
                Price = x.Price,
                Seat = x.Seat,
                Status = x.Status,
                Transmission = x.Transmission,
                BodyType = x.BodyType.Name,
                Location = x.Location.LocationName,
            }).ToList();

            return Task.FromResult(result);
        }
    }
}

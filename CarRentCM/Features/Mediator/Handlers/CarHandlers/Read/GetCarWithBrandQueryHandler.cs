
using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Read
{
    public class GetCarWithBrandQueryHandler : IRequestHandler<GetCarWithBrandQuery, List<GetCarWithBrandQueryResult>>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;

        public GetCarWithBrandQueryHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async  Task<List<GetCarWithBrandQueryResult>> Handle(GetCarWithBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Cars.Include(x => x.Brand).Include(x=> x.BodyType).Include(x=>x.Location).ToListAsync();

            return values.Select(x => new GetCarWithBrandQueryResult
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
        }
    }
}

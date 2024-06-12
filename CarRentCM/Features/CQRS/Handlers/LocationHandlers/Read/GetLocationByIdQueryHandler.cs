using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Queries.LocationQueries;
using CarRentCM.Features.CQRS.Results.LocationResults;

namespace CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read
{
	public class GetLocationByIdQueryHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public GetLocationByIdQueryHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public GetLocationByIdQueryResult Handle(GetLocationByIdQuery query)
		{
			var values = _context.Locations.Find(query.Id);
			var result = _mapper.Map<GetLocationByIdQueryResult>(values);
			return result;

		}
	}
}

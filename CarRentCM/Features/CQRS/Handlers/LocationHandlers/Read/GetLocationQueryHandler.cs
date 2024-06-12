using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Results.LocationResults;

namespace CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read
{
	public class GetLocationQueryHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public GetLocationQueryHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public List<GetLocationQueryResult> Handle()
		{
			var values = _context.Locations.ToList();
			var result = _mapper.Map<List<GetLocationQueryResult>>(values);
			return result;
		}
	}
}

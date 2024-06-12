using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Results.LocationResults;

namespace CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Read
{
	public class GetBodyTypeQueryHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public GetBodyTypeQueryHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public List<GetBodyTypeQueryResult> Handle()
		{
			var values = _context.BodyTypes.ToList();
			var result = _mapper.Map<List<GetBodyTypeQueryResult>>(values);	
			return result;
		}
	}
}

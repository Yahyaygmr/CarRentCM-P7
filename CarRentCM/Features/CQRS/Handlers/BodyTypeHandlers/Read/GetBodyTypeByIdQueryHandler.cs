using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Queries.BodyTypeQueries;
using CarRentCM.Features.CQRS.Results.LocationResults;

namespace CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Read
{
	public class GetBodyTypeByIdQueryHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public GetBodyTypeByIdQueryHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public GetBodyTypeByIdQueryResult Handle(GetBodyTypeByIdQuery query)
		{
			var values = _context.BodyTypes.Find(query.Id);
			var result = _mapper.Map<GetBodyTypeByIdQueryResult>(values);
			return result;
		}
	}
}

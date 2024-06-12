using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Commands.LocationCommands;

namespace CarRentCM.Features.CQRS.Handlers.LocationHandlers.Write
{
	public class CreateLocationCommandHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public CreateLocationCommandHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(CreateLocationCommand command)
		{
			var result = _mapper.Map<Location>(command);
			_context.Locations.Add(result);
			_context.SaveChanges();
		}
	}
}

using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Commands.LocationCommands;

namespace CarRentCM.Features.CQRS.Handlers.LocationHandlers.Write
{
	public class UpdateLocationCommandHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public UpdateLocationCommandHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(UpdateLocationCommand command)
		{
			var result = _mapper.Map<Location>(command);
			_context.Locations.Update(result);
			_context.SaveChanges();
		}
	}
}

using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Commands.BodyTypeCommands;

namespace CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Write
{
	public class UpdateBodyTypeCommandHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public UpdateBodyTypeCommandHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(UpdateBodyTypeCommand command)
		{
			var result = _mapper.Map<BodyType>(command);
			_context.BodyTypes.Update(result);
			_context.SaveChanges();
		}
	}
}

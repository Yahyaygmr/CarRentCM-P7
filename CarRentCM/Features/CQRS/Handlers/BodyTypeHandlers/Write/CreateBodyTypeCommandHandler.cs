using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Commands.BodyTypeCommands;

namespace CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Write
{
	public class CreateBodyTypeCommandHandler
	{
		private readonly CarRentContext _context;
		private readonly IMapper _mapper;

		public CreateBodyTypeCommandHandler(CarRentContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}
		public void Handle(CreateBodyTypeCommand command)
		{
			var result = _mapper.Map<BodyType>(command);
			_context.BodyTypes.Add(result);
			_context.SaveChanges();

		}
	}
}

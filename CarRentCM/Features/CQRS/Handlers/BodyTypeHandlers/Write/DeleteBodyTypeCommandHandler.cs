using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Commands.BodyTypeCommands;

namespace CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Write
{
	public class DeleteBodyTypeCommandHandler
	{
		private readonly CarRentContext _context;

		public DeleteBodyTypeCommandHandler(CarRentContext context)
		{
			_context = context;
		}
		public void Handle(DeleteBodyTypeCommand command)
		{
			var values = _context.BodyTypes.Find(command.Id);
			_context.BodyTypes.Remove(values);
			_context.SaveChanges();
		}
	}
}

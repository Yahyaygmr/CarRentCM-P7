using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Commands.LocationCommands;

namespace CarRentCM.Features.CQRS.Handlers.LocationHandlers.Write
{
	public class DeleteLocationCommandHandler
	{
		private readonly CarRentContext _context;

		public DeleteLocationCommandHandler(CarRentContext context)
		{
			_context = context;
		}
		public void Handle(DeleteLocationCommand command)
		{
			var values = _context.Locations.Find(command.Id);
			_context.Locations.Remove(values);
			_context.SaveChanges();
		}
	}
}

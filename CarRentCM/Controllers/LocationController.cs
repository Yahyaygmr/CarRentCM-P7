using CarRentCM.Features.CQRS.Commands.LocationCommands;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Write;
using CarRentCM.Features.CQRS.Queries.LocationQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.Controllers
{
	public class LocationController : Controller
	{
		private readonly GetLocationQueryHandler _getLocationQueryHandler;
		private readonly GetLocationByIdQueryHandler _getLocationByIdQueryHandler;
		private readonly CreateLocationCommandHandler _createLocationCommandHandler;
		private readonly UpdateLocationCommandHandler _updateLocationCommandHandler;
		private readonly DeleteLocationCommandHandler _deleteLocationCommandHandler;

		public LocationController(GetLocationQueryHandler getLocationQueryHandler, GetLocationByIdQueryHandler getLocationByIdQueryHandler, CreateLocationCommandHandler createLocationCommandHandler, UpdateLocationCommandHandler updateLocationCommandHandler, DeleteLocationCommandHandler deleteLocationCommandHandler)
		{
			_getLocationQueryHandler = getLocationQueryHandler;
			_getLocationByIdQueryHandler = getLocationByIdQueryHandler;
			_createLocationCommandHandler = createLocationCommandHandler;
			_updateLocationCommandHandler = updateLocationCommandHandler;
			_deleteLocationCommandHandler = deleteLocationCommandHandler;
		}

		public IActionResult LocationList()
		{
			var values = _getLocationQueryHandler.Handle();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateLocation()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateLocation(CreateLocationCommand command)
		{
			_createLocationCommandHandler.Handle(command);
			return RedirectToAction("LocationList");
		}
		[HttpGet]
		public IActionResult UpdateLocation(int id)
		{
			var values = _getLocationByIdQueryHandler.Handle(new GetLocationByIdQuery(id));
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateLocation(UpdateLocationCommand command)
		{
			_updateLocationCommandHandler.Handle(command);
			return RedirectToAction("LocationList");
		}
		public IActionResult DeleteLocation(int id)
		{
			_deleteLocationCommandHandler.Handle(new DeleteLocationCommand(id));
			return RedirectToAction("LocationList");
		}
	}
}

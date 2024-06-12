using CarRentCM.Features.CQRS.Commands.BodyTypeCommands;
using CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Write;
using CarRentCM.Features.CQRS.Queries.BodyTypeQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.Controllers
{
	public class BodyTypeController : Controller
	{
		private readonly GetBodyTypeQueryHandler _getBodyTypeQueryHandler;
		private readonly GetBodyTypeByIdQueryHandler _getBodyTypeByIdQueryHandler;
		private readonly CreateBodyTypeCommandHandler _createBodyTypeCommandHandler;
		private readonly UpdateBodyTypeCommandHandler _updateBodyTypeCommandHandler;
		private readonly DeleteBodyTypeCommandHandler _deleteBodyTypeCommandHandler;

		public BodyTypeController(GetBodyTypeQueryHandler getBodyTypeQueryHandler, GetBodyTypeByIdQueryHandler getBodyTypeByIdQueryHandler, CreateBodyTypeCommandHandler createBodyTypeCommandHandler, UpdateBodyTypeCommandHandler updateBodyTypeCommandHandler, DeleteBodyTypeCommandHandler deleteBodyTypeCommandHandler)
		{
			_getBodyTypeQueryHandler = getBodyTypeQueryHandler;
			_getBodyTypeByIdQueryHandler = getBodyTypeByIdQueryHandler;
			_createBodyTypeCommandHandler = createBodyTypeCommandHandler;
			_updateBodyTypeCommandHandler = updateBodyTypeCommandHandler;
			_deleteBodyTypeCommandHandler = deleteBodyTypeCommandHandler;
		}

		public IActionResult BodyTypeList()
		{
			var values = _getBodyTypeQueryHandler.Handle();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateBodyType()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateBodyType(CreateBodyTypeCommand command)
		{
			_createBodyTypeCommandHandler.Handle(command);
			return RedirectToAction("BodyTypeList");
		}
		[HttpGet]
		public IActionResult UpdateBodyType(int id)
		{
			var values = _getBodyTypeByIdQueryHandler.Handle(new GetBodyTypeByIdQuery(id));
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateBodyType(UpdateBodyTypeCommand command)
		{
			_updateBodyTypeCommandHandler.Handle(command);
			return RedirectToAction("BodyTypeList");
		}
		public IActionResult DeleteBodyType(int id)
		{
			_deleteBodyTypeCommandHandler.Handle(new DeleteBodyTypeCommand(id));
			return RedirectToAction("BodyTypeList");
		}
	}
}

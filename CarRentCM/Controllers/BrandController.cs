using CarRentCM.Features.CQRS.Commands.BrandCommands;
using CarRentCM.Features.CQRS.Handlers.BrandHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.BrandHandlers.Write;
using CarRentCM.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.Controllers
{
    public class BrandController : Controller
    {
        private readonly GetBrandQueryHandler _getBrandQueryHandler;
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly DeleteBrandCommandHandler _deleteBrandCommandHandler;

        public BrandController(GetBrandQueryHandler getBrandQueryHandler, GetBrandByIdQueryHandler getBrandByIdQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, DeleteBrandCommandHandler deleteBrandCommandHandler)
        {
            _getBrandQueryHandler = getBrandQueryHandler;
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _deleteBrandCommandHandler = deleteBrandCommandHandler;
        }

        public IActionResult BrandList()
        {
            var values = _getBrandQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(CreateBrandCommand command)
        {
            _createBrandCommandHandler.Handle(command);
            return RedirectToAction("BrandList");
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var values = _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id)); 
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBrand(UpdateBrandCommand command)
        {
            _updateBrandCommandHandler.Handle(command);
            return RedirectToAction("BrandList");
        }
        public IActionResult DeleteBrand(int id)
        {
            _deleteBrandCommandHandler.Handle(new DeleteBrandCommand(id));
            return RedirectToAction("BrandList");
        }
    }
}

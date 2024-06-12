using AutoMapper;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Handlers.BrandHandlers.Read;
using CarRentCM.Features.Mediator.Commands.CarCommands;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.Controllers
{
    public class CarController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;

        public CarController(IMediator mediator, GetBrandQueryHandler getBrandQueryHandler, IMapper mapper)
        {
            _mediator = mediator;
            _getBrandQueryHandler = getBrandQueryHandler;
            _mapper = mapper;
        }

        public async Task<IActionResult> CarList()
        {
            var values = await _mediator.Send(new GetCarWithBrandQuery());
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            ViewBag.brands = GetBrands();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _mediator.Send(command);
            ViewBag.brands = GetBrands();
            return RedirectToAction("CarList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var values = await _mediator.Send(new GetCarByIdQuery(id));
            ViewBag.brands = GetBrands();
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _mediator.Send(command);
            ViewBag.brands = GetBrands();
            return RedirectToAction("CarList");
        }
        public async Task<IActionResult> DeleteCar(int id)
        {
            await _mediator.Send(new DeleteCarCommand(id));
            return RedirectToAction("CarList");
        }
        public  List<Brand> GetBrands()
        {
            var values = _getBrandQueryHandler.Handle();
            List<Brand> result = _mapper.Map<List<Brand>>(values);
            return result;
        }
    }
}

using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read;
using CarRentCM.Features.CQRS.Queries.LocationQueries;
using CarRentCM.Features.CQRS.Results.LocationResults;
using CarRentCM.Features.Mediator.Queries.CarQueries;
using CarRentCM.Features.Mediator.Results.CarResults;
using CarRentCM.Models.CarViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Project;
using System.Globalization;

namespace CarRentCM.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMediator _mediator;
        private readonly GetLocationByIdQueryHandler _getLocationByIdQueryHandler;

        public DefaultController(IMediator mediator, GetLocationByIdQueryHandler getLocationByIdQueryHandler)
        {
            _mediator = mediator;
            _getLocationByIdQueryHandler = getLocationByIdQueryHandler;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarList()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SearchCar(SearchCarViewModel model)
        {
            // Tarih formatını belirleyin
            string dateFormat = "MM/dd/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;

            // Tarihleri parse edin
            DateTime pickUpDate = DateTime.ParseExact(model.PickUpDate, dateFormat, provider);
            DateTime dropOffDate = DateTime.ParseExact(model.DropOffDate, dateFormat, provider);

            // Tarihler arasındaki farkı hesaplayın
            TimeSpan fark = dropOffDate - pickUpDate;

            // Farkın gün cinsinden değerini al
            int gunSayisi = fark.Days;

            // ViewBag.days'e gün sayısını ata
            ViewBag.days = gunSayisi;

            var pLocation = _getLocationByIdQueryHandler.Handle(new GetLocationByIdQuery(model.PickUpLocation));
            var dLocation = _getLocationByIdQueryHandler.Handle(new GetLocationByIdQuery(model.DropOffLocation));
            ViewBag.pickUpLocation = pLocation.LocationName;
            ViewBag.dropOffLocation = dLocation.LocationName;

            var values = await _mediator.Send(new GetCarsWithySerachParametersQuery(model));
            return View(values);
        }
    }
}

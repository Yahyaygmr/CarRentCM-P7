using AutoMapper;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Handlers.BodyTypeHandlers.Read;
using CarRentCM.Features.CQRS.Handlers.LocationHandlers.Read;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.DefaultViewComponents
{
    public class DefaultCarFilterComponentPartial : ViewComponent
    {
        private readonly GetLocationQueryHandler _getLocationQueryHandler;
        private readonly GetBodyTypeQueryHandler _getBodyTypeQueryHandler;
        private readonly IMapper _mapper;

        public DefaultCarFilterComponentPartial(GetLocationQueryHandler getLocationQueryHandler, IMapper mapper, GetBodyTypeQueryHandler getBodyTypeQueryHandler)
        {
            _getLocationQueryHandler = getLocationQueryHandler;
            _mapper = mapper;
            _getBodyTypeQueryHandler = getBodyTypeQueryHandler;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.locations = GetLocations();
            ViewBag.bodyTypes = GetBodyTypes();
            return View();
        }
        public List<Location> GetLocations()
        {
            var values = _getLocationQueryHandler.Handle();
            var result = _mapper.Map<List<Location>>(values);
            return result;

        }
        public List<BodyType> GetBodyTypes()
        {
            var values = _getBodyTypeQueryHandler.Handle();
            var result = _mapper.Map<List<BodyType>>(values);
            return result;
        }
    }
}

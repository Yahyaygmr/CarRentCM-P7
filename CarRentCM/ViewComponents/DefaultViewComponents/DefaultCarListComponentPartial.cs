using CarRentCM.Features.Mediator.Queries.CarQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.DefaultViewComponents
{
    public class DefaultCarListComponentPartial : ViewComponent
    {
        private readonly IMediator _mediator;

        public DefaultCarListComponentPartial(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =await _mediator.Send(new GetCarWithBrandQuery());
            return View(values);
        }
    }
}


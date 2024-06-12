using Microsoft.AspNetCore.Mvc;

namespace CarRentCM.ViewComponents.DefaultViewComponents
{
    public class DefaultCarFilterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

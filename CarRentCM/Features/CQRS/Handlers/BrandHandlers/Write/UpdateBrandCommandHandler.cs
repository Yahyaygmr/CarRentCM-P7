using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Commands.BrandCommands;

namespace CarRentCM.Features.CQRS.Handlers.BrandHandlers.Write
{
    public class UpdateBrandCommandHandler
    {
        private readonly CarRentContext _context;

        public UpdateBrandCommandHandler(CarRentContext context)
        {
            _context = context;
        }
        public void Handle(UpdateBrandCommand command)
        {
            var brand = _context.Brands.Find(command.BrandId);

            brand.Name = command.Name;
            _context.SaveChanges();
        }
    }
}

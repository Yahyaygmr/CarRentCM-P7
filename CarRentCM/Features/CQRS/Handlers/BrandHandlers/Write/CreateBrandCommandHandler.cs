using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Commands.BrandCommands;

namespace CarRentCM.Features.CQRS.Handlers.BrandHandlers.Write
{
    public class CreateBrandCommandHandler
    {
        private readonly CarRentContext _context;

        public CreateBrandCommandHandler(CarRentContext context)
        {
            _context = context;
        }
        public void Handle(CreateBrandCommand command)
        {
            _context.Brands.Add(new() { Name = command.Name });
            _context.SaveChanges();
        }
    }
}

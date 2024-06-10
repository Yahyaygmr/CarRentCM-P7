using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Commands.BrandCommands;

namespace CarRentCM.Features.CQRS.Handlers.BrandHandlers.Write
{
    public class DeleteBrandCommandHandler
    {
        private readonly CarRentContext _context;

        public DeleteBrandCommandHandler(CarRentContext context)
        {
            _context = context;
        }
        public void Handle(DeleteBrandCommand command)
        {
            var brand = _context.Brands.Find(command.Id);

            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }
    }
}

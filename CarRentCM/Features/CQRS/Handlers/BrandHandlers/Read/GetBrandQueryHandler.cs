using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Results.BrandResults;

namespace CarRentCM.Features.CQRS.Handlers.BrandHandlers.Read
{
    public class GetBrandQueryHandler
    {
        private readonly CarRentContext _context;

        public GetBrandQueryHandler(CarRentContext context)
        {
            _context = context;
        }
        public List<GetBrandQueryResult> Handle()
        {
            var brands = _context.Brands.ToList();

            return brands.Select(b => new GetBrandQueryResult()
            {
                BrandId = b.BrandId,
                Name = b.Name,
            }).ToList();
        }
    }
}

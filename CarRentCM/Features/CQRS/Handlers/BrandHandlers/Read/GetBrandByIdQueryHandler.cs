using CarRentCM.DAL.Context;
using CarRentCM.Features.CQRS.Queries.BrandQueries;
using CarRentCM.Features.CQRS.Results.BrandResults;

namespace CarRentCM.Features.CQRS.Handlers.BrandHandlers.Read
{
    public class GetBrandByIdQueryHandler
    {
        private readonly CarRentContext _context;

        public GetBrandByIdQueryHandler(CarRentContext context)
        {
            _context = context;
        }
        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var brand = _context.Brands.Find(query.Id);

            return new GetBrandByIdQueryResult()
            {
                BrandId = brand.BrandId,
                Name = brand.Name,
            };
        }
    }
}

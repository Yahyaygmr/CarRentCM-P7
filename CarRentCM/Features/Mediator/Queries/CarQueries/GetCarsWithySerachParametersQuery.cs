using CarRentCM.Features.Mediator.Results.CarResults;
using CarRentCM.Models.CarViewModels;
using MediatR;

namespace CarRentCM.Features.Mediator.Queries.CarQueries
{
    public class GetCarsWithySerachParametersQuery : IRequest<List<GetCarsWithySerachParametersQueryResult>>
    {
        public GetCarsWithySerachParametersQuery(SearchCarViewModel model)
        {
            BodyType = model.BodyType;
            PickUpDate = model.PickUpDate;
            DropOffDate = model.DropOffDate;
            PickUpLocation = model.PickUpLocation;
            DropOffLocation = model.DropOffLocation;
        }

        public int BodyType { get; set; }
        public string PickUpDate { get; set; }
        public string DropOffDate { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOffLocation { get; set; }
    }
}

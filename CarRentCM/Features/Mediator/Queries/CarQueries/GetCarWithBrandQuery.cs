﻿using CarRentCM.Features.Mediator.Results.CarResults;
using MediatR;

namespace CarRentCM.Features.Mediator.Queries.CarQueries
{
    public class GetCarWithBrandQuery : IRequest<List<GetCarWithBrandQueryResult>>
    {
    }
}

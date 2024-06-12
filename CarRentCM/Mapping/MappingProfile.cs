using AutoMapper;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.CQRS.Commands.BodyTypeCommands;
using CarRentCM.Features.CQRS.Commands.LocationCommands;
using CarRentCM.Features.CQRS.Results.BodyTypeResults;
using CarRentCM.Features.CQRS.Results.BrandResults;
using CarRentCM.Features.CQRS.Results.LocationResults;
using CarRentCM.Features.Mediator.Commands.CarCommands;
using CarRentCM.Features.Mediator.Results.CarResults;

namespace CarRentCM.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Car, GetCarQueryResult>().ReverseMap();
            CreateMap<Car, GetCarByIdQueryResult>().ReverseMap();
            CreateMap<CreateCarCommand, Car>().ReverseMap();
            CreateMap<UpdateCarCommand, Car>().ReverseMap();
            CreateMap<GetCarWithBrandQueryResult, Car>().ReverseMap();

            CreateMap<GetBrandQueryResult, Brand>().ReverseMap();

            CreateMap<GetLocationQueryResult, Location>().ReverseMap();
            CreateMap<GetLocationByIdQueryResult, Location>().ReverseMap();
            CreateMap<CreateLocationCommand, Location>().ReverseMap();
            CreateMap<UpdateLocationCommand, Location>().ReverseMap();

            CreateMap<GetBodyTypeByIdQueryResult, BodyType>().ReverseMap();
            CreateMap<GetBodyTypeQueryResult, BodyType>().ReverseMap();
            CreateMap<CreateBodyTypeCommand, BodyType>().ReverseMap();
            CreateMap<UpdateBodyTypeCommand, BodyType>().ReverseMap();
        }
    }
}

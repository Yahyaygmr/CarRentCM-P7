using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;
        public CreateCarCommandHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Car>(request);
            _context.Cars.Add(result);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}

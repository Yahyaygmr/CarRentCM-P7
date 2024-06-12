using AutoMapper;
using CarRentCM.DAL.Context;
using CarRentCM.DAL.Entities;
using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        private readonly CarRentContext _context;
        private readonly IMapper _mapper;

        public UpdateCarCommandHandler(CarRentContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            var result = _mapper.Map<Car>(request);

            _context.Update(result);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}

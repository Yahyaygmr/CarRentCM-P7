using CarRentCM.DAL.Context;
using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
    {
        private readonly CarRentContext _context;

        public DeleteCarCommandHandler(CarRentContext context)
        {
            _context = context;
        }

        public Task Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Cars.Find(request.Id);

            _context.Cars.Remove(values);
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}

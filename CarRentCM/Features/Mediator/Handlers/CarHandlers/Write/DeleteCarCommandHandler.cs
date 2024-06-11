using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class DeleteCarCommandHandler : IRequestHandler<DeleteCarCommand>
    {
        public Task Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

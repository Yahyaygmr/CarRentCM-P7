using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand>
    {
        public Task Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

using CarRentCM.Features.Mediator.Commands.CarCommands;
using MediatR;

namespace CarRentCM.Features.Mediator.Handlers.CarHandlers.Write
{
    public class UpdateCarCommandHandler : IRequestHandler<UpdateCarCommand>
    {
        public Task Handle(UpdateCarCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

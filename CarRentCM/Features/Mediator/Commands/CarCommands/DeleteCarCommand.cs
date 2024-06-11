﻿using MediatR;

namespace CarRentCM.Features.Mediator.Commands.CarCommands
{
    public class DeleteCarCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteCarCommand(int id)
        {
            Id = id;
        }
    }
}

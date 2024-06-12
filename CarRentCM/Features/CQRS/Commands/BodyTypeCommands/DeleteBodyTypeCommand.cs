namespace CarRentCM.Features.CQRS.Commands.BodyTypeCommands
{
	public class DeleteBodyTypeCommand
	{
        public int Id { get; set; }

		public DeleteBodyTypeCommand(int id)
		{
			Id = id;
		}
	}
}

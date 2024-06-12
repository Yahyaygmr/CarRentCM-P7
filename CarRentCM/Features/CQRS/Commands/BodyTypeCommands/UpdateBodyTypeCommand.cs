namespace CarRentCM.Features.CQRS.Commands.BodyTypeCommands
{
	public class UpdateBodyTypeCommand
	{
		public int BodyTypeId { get; set; }
		public string Name { get; set; }
	}
}

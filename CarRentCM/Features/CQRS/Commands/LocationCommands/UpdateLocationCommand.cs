namespace CarRentCM.Features.CQRS.Commands.LocationCommands
{
	public class UpdateLocationCommand
	{
		public int LocationId { get; set; }
		public string LocationName { get; set; }
		public bool Status { get; set; }
	}
}

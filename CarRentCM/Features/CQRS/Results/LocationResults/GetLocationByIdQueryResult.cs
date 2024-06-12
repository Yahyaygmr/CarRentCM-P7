namespace CarRentCM.Features.CQRS.Results.LocationResults
{
	public class GetLocationByIdQueryResult
	{
		public int LocationId { get; set; }
		public string LocationName { get; set; }
		public bool Status { get; set; }
	}
}

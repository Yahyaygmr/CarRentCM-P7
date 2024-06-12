namespace CarRentCM.Features.CQRS.Results.LocationResults
{
	public class GetLocationQueryResult
	{
		public int LocationId { get; set; }
		public string LocationName { get; set; }
		public bool Status { get; set; }
	}
}

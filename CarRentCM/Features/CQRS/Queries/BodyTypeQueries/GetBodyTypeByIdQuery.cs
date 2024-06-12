namespace CarRentCM.Features.CQRS.Queries.BodyTypeQueries
{
	public class GetBodyTypeByIdQuery
	{
        public int Id { get; set; }

		public GetBodyTypeByIdQuery(int id)
		{
			Id = id;
		}
	}
}

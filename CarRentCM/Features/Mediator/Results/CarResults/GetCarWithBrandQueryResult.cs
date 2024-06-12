namespace CarRentCM.Features.Mediator.Results.CarResults
{
    public class GetCarWithBrandQueryResult
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
        public int Km { get; set; }
        public int Door { get; set; }
        public string Transmission { get; set; }
        public int Seat { get; set; }
        public int Luggage { get; set; }
        public string Fuel { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string BrandName { get; set; }
        public string Location { get; set; }
        public string BodyType { get; set; }
    }
}

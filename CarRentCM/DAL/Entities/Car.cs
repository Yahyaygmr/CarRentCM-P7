﻿namespace CarRentCM.DAL.Entities
{
    public class Car
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
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int BodyTypeId { get; set; }
        public BodyType BodyType { get; set; }

        public List<RentACar> RentACars { get; set; }
    }
}

namespace CarRentCM.DAL.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public bool Status { get; set; }
        public List<Car> Cars { get; set; }
        public List<RentACar> PickUpLocation { get; set; }
        public List<RentACar> DropOffLocation { get; set; }
    }
}

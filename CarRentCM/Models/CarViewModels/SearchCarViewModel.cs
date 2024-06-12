namespace CarRentCM.Models.CarViewModels
{
    public class SearchCarViewModel
    {
        public int BodyType { get; set; }
        public string PickUpDate { get; set; }
        public string DropOffDate { get; set; }
        public int PickUpLocation { get; set; }
        public int DropOffLocation { get; set; }
    }
}

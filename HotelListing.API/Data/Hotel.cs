namespace HotelListing.API.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Raiting { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
    }
}

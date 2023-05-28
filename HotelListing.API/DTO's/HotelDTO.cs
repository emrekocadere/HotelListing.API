using HotelListing.API.Data;

namespace HotelListing.API.DTO_s
{
    public class HotelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Raiting { get; set; }
        public int CountryID { get; set; }

    }
}

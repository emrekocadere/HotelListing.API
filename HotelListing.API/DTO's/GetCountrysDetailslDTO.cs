namespace HotelListing.API.DTO_s
{
    public class GetCountrysDetailslDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public List<HotelDTO> Hotels { get; set; }
    }
}

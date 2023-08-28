using HotelList.API.Models.Hotel;

namespace HotelList.API.Models.Country
{
    public class UpdateCountryDto : BaseCountryDto
    {
        public int Id { get; set; } 
        public List<HotelDto> Hotels { get; set; }
    }
}

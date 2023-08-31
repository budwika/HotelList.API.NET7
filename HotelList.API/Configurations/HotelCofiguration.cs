using HotelList.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelList.API.Configurations
{
    public class HotelCofiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5,
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 4.3,
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassuna",
                    CountryId = 2,
                    Rating = 4,
                }
                );
        }
    }
}

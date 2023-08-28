using HotelList.API.Contracts;
using HotelList.API.Data;

namespace HotelList.API.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelRepository(HotelListingDbContext context) : base(context)
        {
        }
    }
}

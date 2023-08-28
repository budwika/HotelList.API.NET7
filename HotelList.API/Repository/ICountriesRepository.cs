using HotelList.API.Data;

namespace HotelList.API.Repository
{
    public interface ICountriesRepository : IGenericRepository<Country> 
    { 
        Task<Country> GetDetails(int id);
    }
}

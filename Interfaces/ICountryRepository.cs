using PokReviewApp.Models;

namespace PokReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromAtCountry(int countryId);
        bool CountryExists(int id);
    }
}

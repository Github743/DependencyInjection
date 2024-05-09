using DependencyApi.Models.Database;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyApi.DAL
{
    public class BMA_DAL
    {
        public async Task<string> GetCountryNameAsync(int countryId)
        {
            var model = new BMAModel();
            return await model.Countries.Where(c => c.CountryId == countryId).Select(c => c.CountryName.Trim()).FirstOrDefaultAsync();
        }
    }
}
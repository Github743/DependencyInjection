using DependencyApi.Models.Database;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyApi.DAL
{
    public class BMA_DAL
    {
        private BMAModel _bMAModel;

        public BMA_DAL()
        {
            _bMAModel = new BMAModel();
        }

        public BMA_DAL(string connection)
        {
            _bMAModel = new BMAModel(connection);
        }

        public async Task<string> GetCountryNameAsync(int countryId)
        {
            return await _bMAModel.Countries.Where(c => c.CountryId == countryId).Select(c => c.CountryName.Trim()).FirstOrDefaultAsync();
        }
    }
}
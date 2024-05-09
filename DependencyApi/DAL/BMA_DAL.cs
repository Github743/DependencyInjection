using DependencyApi.Models.Database;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyApi.DAL
{
    public class BMA_DAL
    {
        private readonly BMAModel _bMAModel;

        public BMA_DAL()
        {
            _bMAModel = new BMAModel();
        }
        public async Task<string> GetCountryNameAsync(int countryId)
        {
            _bMAModel.Database.Connection.ConnectionString = "data source=.;initial catalog=BMA_CMS_TEST;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
            //var model = new BMAModel();
            return await _bMAModel.Countries.Where(c => c.CountryId == countryId).Select(c => c.CountryName.Trim()).FirstOrDefaultAsync();
        }
    }
}
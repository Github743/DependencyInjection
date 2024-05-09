using DependencyApi.DAL;
using DependencyApi.Models.Database;
using System.Threading.Tasks;

namespace DependencyApi.BLL
{
    public class Customer_BLL : ICustomer_BLL
    {
        private BMA_DAL _dal;

        public Customer_BLL()
        {
            _dal = new BMA_DAL();
        }
        public async Task<string> GetCountryNameAsync(int countryId)
        {
            _dal = new BMA_DAL("data source=.;initial catalog=BMA_CMS_TEST;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework");
            return await _dal.GetCountryNameAsync(countryId);
        }
    }
}
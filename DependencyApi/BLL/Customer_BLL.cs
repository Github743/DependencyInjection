using DependencyApi.DAL;
using DependencyApi.Models.Database;
using System.Threading.Tasks;

namespace DependencyApi.BLL
{
    public class Customer_BLL : ICustomer_BLL
    {
        private readonly BMA_DAL _dal;

        public Customer_BLL()
        {
            _dal = new BMA_DAL();
        }
        public async Task<string> GetCountryNameAsync(int countryId)
        {
            return await _dal.GetCountryNameAsync(countryId);
        }
    }
}
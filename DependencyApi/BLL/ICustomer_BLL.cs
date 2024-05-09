using System.Threading.Tasks;

namespace DependencyApi.BLL
{
    public interface ICustomer_BLL
    {
        Task<string> GetCountryNameAsync(int countryId);
    }
}

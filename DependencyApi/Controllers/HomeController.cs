using DependencyApi.BLL;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Web.Http;

namespace DependencyApi.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ICustomer_BLL _Customer_BLL;
        public HomeController()
        {
            var serviceProvider = new ServiceCollection().AddSingleton<ICustomer_BLL, Customer_BLL>().BuildServiceProvider();
            _Customer_BLL = serviceProvider.GetService<ICustomer_BLL>();
        }

        [Route("api/Country")]
        [HttpGet]
        public async Task<IHttpActionResult> GetCountryNameAsync(int countryId)
        {
            var response = await Task.Run(() => _Customer_BLL.GetCountryNameAsync(countryId));
            return Ok(response);
        }
    }
}

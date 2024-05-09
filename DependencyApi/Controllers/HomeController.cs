using DependencyApi.BLL;
using DependencyApi.Models;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Web.Http;

namespace DependencyApi.Controllers
{
    public class SalesInvoiceController : ApiController
    {
        private readonly ICustomer_BLL _Customer_BLL;
        public SalesInvoiceController()
        {
            var serviceProvider = new ServiceCollection().AddSingleton<ICustomer_BLL, Customer_BLL>().BuildServiceProvider();
            _Customer_BLL = serviceProvider.GetService<ICustomer_BLL>();
        }

        [Route("api/Country")]
        [HttpGet]
        public async Task<IHttpActionResult> GetCountryNameAsync([FromBody] int countryId)
        {
            var response = await Task.Run(() => _Customer_BLL.GetCountryNameAsync(countryId));
            return Ok(response);
        }
    }
}

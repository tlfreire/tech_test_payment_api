using Microsoft.AspNetCore.Mvc;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {


        [HttpGet]
        public string Get()
        {
            return "apiiiiiiiii";
        }
    }
}
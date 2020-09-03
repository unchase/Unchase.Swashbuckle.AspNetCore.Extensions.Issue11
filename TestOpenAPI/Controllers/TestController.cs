using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace TestOpenAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [SwaggerTag("Test controller")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Authorize payment.
        /// </summary>
        /// <param name="checkout">The checkout.</param>
        /// <returns>Returns result.</returns>
        [HttpPost]
        public async Task<ActionResult<WebshopAuthorizePaymentResponse>> AuthorizePayment([FromBody] AuthorizePaymentBody checkout)
        {
            _logger.LogInformation("{0} method was called.", nameof(AuthorizePayment));

            await Task.FromResult(1);

            return Ok(new WebshopAuthorizePaymentResponse 
            {
                ErrorCode = PaymentErrorCode.NoError 
            });
        }
    }
}

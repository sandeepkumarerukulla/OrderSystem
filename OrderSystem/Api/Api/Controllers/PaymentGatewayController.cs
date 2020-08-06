using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Threading.Tasks;
using Common.Interfaces;
using Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/paymentgateway")]
    [ApiController]
    public class PaymentGatewayController : ControllerBase
    {

        private readonly IPaymentGatewayService paymentGatewayService;

        public PaymentGatewayController(IPaymentGatewayService paymentsService)
        {
            this.paymentGatewayService = paymentsService;
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([Required] PaymentSelection paymentSelection)
        {
            try
            {
                if (!string.IsNullOrEmpty(paymentSelection.Type))
                {
                    var response = new PaymentSelection()
                    {
                        Type = await this.paymentGatewayService.Process(paymentSelection.Type.ToLower())
                    };
                    return Ok(response);
                }

                return BadRequest("Provide valid payment type from given types");
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}

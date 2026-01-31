using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.PaymentDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class PaymentController : Controller
    {
        private readonly IPaymentServices _paymentServices;

        public PaymentController(IPaymentServices paymentServices)
        {
            _paymentServices = paymentServices;
        }

        [HttpGet("GetAllPayments")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _paymentServices.GetAllPaymentsAsync();
            return Ok(list);
        }

        [HttpPost("AddPayment")]
        public async Task<IActionResult> AddPayment([FromBody] AddPaymentDTO paymentDto)
        {
            var result = await _paymentServices.AddPaymentAsync(paymentDto);
            return Ok(result);
        }

        [HttpPut("UpdatePayment/{id}")]
        public async Task<IActionResult> UpdatePayment(int id, [FromBody] UpdatePaymentDTO paymentDto)
        {
            var result = await _paymentServices.UpdatePaymentAsync(id, paymentDto);
            return Ok(result);
        }
    }
}

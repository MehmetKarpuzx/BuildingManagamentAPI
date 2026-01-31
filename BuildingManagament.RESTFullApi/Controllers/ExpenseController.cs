using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.ExpenseDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class ExpenseController : Controller
    {
        private readonly IExpenseServices _expenseServices;

        public ExpenseController(IExpenseServices expenseServices)
        {
            _expenseServices = expenseServices;
        }

        [HttpGet("GetAllExpenses")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _expenseServices.GetAllExpensesAsync();
            return Ok(list);
        }

        [HttpPost("AddExpense")]
        public async Task<IActionResult> AddExpense([FromBody] AddExpenseDTO expenseDto)
        {
            var result = await _expenseServices.AddExpenseAsync(expenseDto);
            return Ok(result);
        }

        [HttpPut("UpdateExpense/{id}")]
        public async Task<IActionResult> UpdateExpense(int id, [FromBody] UpdateExpenseDTO expenseDto)
        {
            var result = await _expenseServices.UpdateExpenseAsync(id, expenseDto);
            return Ok(result);
        }
    }
}

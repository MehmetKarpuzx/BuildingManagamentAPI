using BuildingManagament.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]   //PROJE GELİŞTİRME AŞAMASINDA İZİN VERİYORUZ, PROD'DA KALDIRILACAK
    public class ExpenseCategoryController : Controller
    {
        private readonly IExpenseCategoryServices _expenseCategoryServices;
        public ExpenseCategoryController(IExpenseCategoryServices expenseCategoryServices)
        {
            _expenseCategoryServices = expenseCategoryServices;
        }
        [HttpGet("GetAllExpenseCategory")]
        public async Task<IActionResult> GetAll()
        {
            var list = _expenseCategoryServices.GetAllExpenseCategoriesAsync();
            return await Task.FromResult<IActionResult>(Ok(list));
        }
        [HttpPost("AddExpenseCategory")]
        public async Task<IActionResult> AddExpenseCategory([FromBody] DTO.ExpenseCategoryDTOs.AddExpenseCategoryDTO expenseCategoryDto)
        {
            var result = await _expenseCategoryServices.AddExpenseCategoryAsync(expenseCategoryDto);
            return Ok(result);
        }
        [HttpPut("UpdateExpenseCategory/{id}")]
        public async Task<IActionResult> UpdateExpenseCategory(int id, [FromBody] DTO.ExpenseCategoryDTOs.UpdateExpenseCategoryDTO expenseCategoryDto)
        {
            var result = await _expenseCategoryServices.UpdateExpenseCategoryAsync(id, expenseCategoryDto);
            return Ok(result);
        }
    }
}

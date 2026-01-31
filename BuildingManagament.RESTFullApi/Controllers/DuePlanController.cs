using BuildingManagament.Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]   //PROJE GELİŞTİRME AŞAMASINDA İZİN VERİYORUZ, PROD'DA KALDIRILACAK
    public class DuePlanController : Controller
    {
        private readonly IDuePlanServices _duePlanServices;
        public DuePlanController(IDuePlanServices duePlanServices)
        {
            _duePlanServices = duePlanServices;
        }
        [HttpGet("GetAllDuePlans")]
        public async Task<IActionResult> GetAll()
        {
            var list = _duePlanServices.GetAllDuePlansAsync();
            return  await Task.FromResult<IActionResult>(Ok(list));
        }
        [HttpPost("AddDuePlan")]
        public async Task<IActionResult> AddDuePlan([FromBody] DTO.DuePlanDTOs.AddDuePlanDTO duePlanDto)
        {
            var result = await _duePlanServices.AddDuePlanAsync(duePlanDto);
            return Ok(result);
        }
        [HttpPut("UpdateDuePlan/{id}")]
        public async Task<IActionResult> UpdateDuePlan(int id, [FromBody] DTO.DuePlanDTOs.UpdateDuePlanDTO duePlanDto)
        {
            var result = await _duePlanServices.UpdateDuePlanAsync(id, duePlanDto);
            return Ok(result);
        }
    }
}

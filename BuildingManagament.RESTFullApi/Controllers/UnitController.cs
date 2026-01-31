using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.UnitDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class UnitController : Controller
    {
        private readonly IUnitServices _unitServices;

        public UnitController(IUnitServices unitServices)
        {
            _unitServices = unitServices;
        }

        [HttpGet("GetAllUnits")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _unitServices.GetAllUnitsAsync();
            return Ok(list);
        }

        [HttpPost("AddUnit")]
        public async Task<IActionResult> AddUnit([FromBody] AddUnitDTO unitDto)
        {
            var result = await _unitServices.AddUnitAsync(unitDto);
            return Ok(result);
        }

        [HttpPut("UpdateUnit/{id}")]
        public async Task<IActionResult> UpdateUnit(int id, [FromBody] UpdateUnitDTO unitDto)
        {
            var result = await _unitServices.UpdateUnitAsync(id, unitDto);
            return Ok(result);
        }
    }
}

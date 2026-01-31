using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.BuildingDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]   //PROJE GELİŞTİRME AŞAMASINDA İZİN VERİYORUZ, PROD'DA KALDIRILACAK
    public class BuildingController : Controller
    {
        private readonly IBuildingServices _buildingServices;

        public BuildingController(IBuildingServices buildingServices)
        {
            _buildingServices = buildingServices;
        }

        [HttpGet("GetAllBuildings")]
        public Task<IActionResult> GetAll()
        {
            var list = _buildingServices.GetAllBuildingsAsync();
            return Task.FromResult<IActionResult>(Ok(list));
        }
        [HttpPost("AddBuilding")]
        public async Task<IActionResult> AddBuilding([FromBody] AddBuildingDTO buildingDto)
        {
            var result = await _buildingServices.AddBuildingAsync(buildingDto);
            return Ok(result);
        }
        [HttpPut("UpdateBuilding/{id}")]
        public async Task<IActionResult> UpdateBuilding(int id, [FromBody] UpdateBuildingDTO buildingDto)
        {
            var result = await _buildingServices.UpdateBuildingAsync(id, buildingDto);
            return Ok(result);
        }
    }
}

using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.RoleDTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuildingManagament.RESTFullApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [AllowAnonymous]
    public class RoleController : Controller
    {
        private readonly IRoleServices _roleServices;

        public RoleController(IRoleServices roleServices)
        {
            _roleServices = roleServices;
        }

        [HttpGet("GetAllRoles")]
        public async Task<IActionResult> GetAll()
        {
            var list = await _roleServices.GetAllRolesAsync();
            return Ok(list);
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole([FromBody] AddRoleDTO roleDto)
        {
            var result = await _roleServices.AddRoleAsync(roleDto);
            return Ok(result);
        }

        [HttpPut("UpdateRole/{id}")]
        public async Task<IActionResult> UpdateRole(int id, [FromBody] UpdateRoleDTO roleDto)
        {
            var result = await _roleServices.UpdateRoleAsync(id, roleDto);
            return Ok(result);
        }
    }
}

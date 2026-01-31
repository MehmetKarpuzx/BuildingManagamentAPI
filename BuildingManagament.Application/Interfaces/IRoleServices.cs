using BuildingManagament.DTO.RoleDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IRoleServices 
    {
        Task<IEnumerable<ResponseRoleDTO>> GetAllRolesAsync();
        Task<AddRoleDTO> AddRoleAsync(AddRoleDTO roleDto);
        Task<UpdateRoleDTO> UpdateRoleAsync(int id, UpdateRoleDTO roleDto);

    }
}

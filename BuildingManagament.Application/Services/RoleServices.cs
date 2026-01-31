using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.RoleDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly BuildingManagamentDbContext _context;
        public RoleServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public  async Task<AddRoleDTO> AddRoleAsync(AddRoleDTO roleDto)
        {
            var role = new BuildingManagament.Domain.Entities.Role
            {
                Name = roleDto.Name
            };
            await _context.Roles.AddAsync(role);
            await  _context.SaveChangesAsync();
            return roleDto;
        }

        public async Task<IEnumerable<ResponseRoleDTO>> GetAllRolesAsync()
        {
            var list = _context.Roles.Select(r => new ResponseRoleDTO
            {
                Id = r.Id,
                Name = r.Name,
                CreatedDate = r.CreatedDate
            }).AsEnumerable();
            return await Task.FromResult(list);

        }

        public Task<UpdateRoleDTO> UpdateRoleAsync(int id, UpdateRoleDTO roleDto)
        {
            var role =  _context.Roles.Find(id);
            if (role == null)
            {
                throw new Exception("404");
            }
            role.Name = roleDto.Name;
            _context.Roles.Update(role);
            _context.SaveChanges();
            return Task.FromResult(roleDto);
        }
    }
}

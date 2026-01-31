using BuildingManagament.Application.Interfaces;
using BuildingManagament.Domain.Entities;
using BuildingManagament.DTO.UserDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class UserServices : IUserServices
    {
        private readonly BuildingManagamentDbContext _context;
        public async Task<AddUserDTO> AddUserAsync(AddUserDTO userDto)
        {
            var user = new User
            {
                TC = userDto.TC,
                Name = userDto.Name,
                Surname = userDto.Surname,
                UserName = userDto.UserName,
                PasswordHash = userDto.Password,
                PhoneNumber = userDto.PhoneNumber,
                RoleId = userDto.RoleId,
                BuildingId = userDto.BuildingId,
                UnitId = userDto.UnitId
            };
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return userDto;
        }

        public async Task<IEnumerable<ResponseUserDTO>> GetAllUsersAsync()
        {
            var list = _context.Users.Select(u => new ResponseUserDTO
            {
                Id = u.Id,
                TC = u.TC,
                Name = u.Name,
                Surname = u.Surname,
                UserName = u.UserName,
                PhoneNumber = u.PhoneNumber,
                RoleId = u.RoleId,
                BuildingId = u.BuildingId,
                UnitId = u.UnitId,
                CreatedDate = u.CreatedDate
            }).AsEnumerable();
            return await Task.FromResult(list);

        }

        public Task<UpdateUserDTO> UpdateUserAsync(int id, UpdateUserDTO userDto)
        {
            var user = _context.Users.Find(id);
            if (user == null)
            {
                throw new Exception("404");
            }
            user.UserName = userDto.UserName;
            user.Name = userDto.Name;
            user.Surname = userDto.Surname;
            user.TC = userDto.TC;
            user.PhoneNumber = userDto.PhoneNumber;
            user.RoleId = userDto.RoleId;
            user.BuildingId = userDto.BuildingId;
            user.UnitId = userDto.UnitId;
            _context.Users.Update(user);
            _context.SaveChanges();
            return Task.FromResult(userDto);

        }
    }
}

using BuildingManagament.DTO.UserDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<ResponseUserDTO>> GetAllUsersAsync();
        Task<AddUserDTO> AddUserAsync(AddUserDTO userDto);
        Task<UpdateUserDTO> UpdateUserAsync(int id, UpdateUserDTO userDto);
    }
}

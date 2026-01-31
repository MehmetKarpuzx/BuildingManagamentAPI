using BuildingManagament.DTO.DuePlanDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IDuePlanServices
    {
        Task<IEnumerable<ResponseDuePlanDTO>> GetAllDuePlansAsync();
        Task<AddDuePlanDTO> AddDuePlanAsync(AddDuePlanDTO duePlanDto);
        Task<UpdateDuePlanDTO> UpdateDuePlanAsync(int id, UpdateDuePlanDTO duePlanDto);
    }
}

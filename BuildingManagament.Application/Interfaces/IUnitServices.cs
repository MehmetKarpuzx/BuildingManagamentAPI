using BuildingManagament.DTO.UnitDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IUnitServices
    {
        Task<IEnumerable<ResponseUnitDTO>> GetAllUnitsAsync();
        Task<AddUnitDTO> AddUnitAsync(AddUnitDTO unitDto);
        Task<UpdateUnitDTO> UpdateUnitAsync(int id, UpdateUnitDTO unitDto);
    }
}

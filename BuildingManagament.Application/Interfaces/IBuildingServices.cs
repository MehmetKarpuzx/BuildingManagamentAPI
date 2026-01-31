using BuildingManagament.DTO.BuildingDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IBuildingServices
    {
        Task<IEnumerable<ResponseBuildingDTO>> GetAllBuildingsAsync();
        Task<AddBuildingDTO> AddBuildingAsync(AddBuildingDTO buildingDto);
        Task<UpdateBuildingDTO> UpdateBuildingAsync(int id, UpdateBuildingDTO buildingDto);
    }
}

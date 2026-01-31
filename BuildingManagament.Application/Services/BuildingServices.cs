using BuildingManagament.Application.Interfaces;
using BuildingManagament.Domain.Entities;
using BuildingManagament.DTO.BuildingDTOs;
using BuildingManagament.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class BuildingServices : IBuildingServices
    {
        private readonly BuildingManagamentDbContext _context;
        public BuildingServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddBuildingDTO> AddBuildingAsync(AddBuildingDTO buildingDto)
        {
           var building = new Building
           {
               Name = buildingDto.Name,
               Address = buildingDto.Address
           };
              _context.Buildings.Add(building);
                await _context.SaveChangesAsync();
                return buildingDto;
        }

        public async Task<IEnumerable<ResponseBuildingDTO>> GetAllBuildingsAsync()
        {
            var buildings = await _context.Buildings.Select(b => new ResponseBuildingDTO
            {
                Id = b.Id,
                Name = b.Name,
                Address = b.Address,
                CreatedDate = b.CreatedDate
            }).ToListAsync();
            return buildings;

        }

        public Task<UpdateBuildingDTO> UpdateBuildingAsync(int id, UpdateBuildingDTO buildingDto)
        {
            var building = _context.Buildings.Find(id);
            if (building == null)
            {
                throw new Exception("Bina Bulunamadı!");
            }
            building.Name = buildingDto.Name;
            building.Address = buildingDto.Address;
            _context.Buildings.Update(building);
            _context.SaveChanges();
            return Task.FromResult(buildingDto);
        }
    }
}

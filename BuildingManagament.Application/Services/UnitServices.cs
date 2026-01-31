using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.UnitDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class UnitServices : IUnitServices
    {
        private readonly BuildingManagamentDbContext _context;
        public UnitServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddUnitDTO> AddUnitAsync(AddUnitDTO unitDto)
        {
            var unit = new BuildingManagament.Domain.Entities.Unit
            {
                BuildingId = unitDto.BuildingId,
                Block = unitDto.Block,
                FloorNo = unitDto.FloorNo,
                DoorNo = unitDto.DoorNo
            };  
            await _context.Units.AddAsync(unit);
            await _context.SaveChangesAsync();
            return unitDto;

        }

        public Task<IEnumerable<ResponseUnitDTO>> GetAllUnitsAsync()
        {
            var list = _context.Units.Select(u => new ResponseUnitDTO
            {
                Id = u.Id,
                BuildingId = u.BuildingId,
                Block = u.Block,
                FloorNo = u.FloorNo,
                DoorNo = u.DoorNo,
                CreatedDate = u.CreatedDate
            }).AsEnumerable();
            return Task.FromResult(list);

        }

        public Task<UpdateUnitDTO> UpdateUnitAsync(int id, UpdateUnitDTO unitDto)
        {
            var unit = _context.Units.Find(id); 
            if (unit == null)
            {
                throw new Exception("404");
            }
            unit.BuildingId = unitDto.BuildingId;
                
            unit.Block = unitDto.Block;
            unit.FloorNo = unitDto.FloorNo;
            unit.DoorNo = unitDto.DoorNo;
            _context.Units.Update(unit);
            _context.SaveChanges();
            return Task.FromResult(unitDto);

        }
    }
}

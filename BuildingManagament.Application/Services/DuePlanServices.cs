using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.DuePlanDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class DuePlanServices : IDuePlanServices
    {
        private readonly BuildingManagamentDbContext _context;
        public DuePlanServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddDuePlanDTO> AddDuePlanAsync(AddDuePlanDTO duePlanDto)
        {
            var duePlan = new BuildingManagament.Domain.Entities.DuePlan
            {
                BuildingId = duePlanDto.BuildingId,
                Name = duePlanDto.Name,
                Amount = duePlanDto.Amount
            };
            await _context.DuePlans.AddAsync(duePlan);
            await _context.SaveChangesAsync();
            return duePlanDto;

        }

        public Task<IEnumerable<ResponseDuePlanDTO>> GetAllDuePlansAsync()
        {
            var list = _context.DuePlans.Select(dp => new ResponseDuePlanDTO
            {
                Id = dp.Id,
                BuildingId = dp.BuildingId,
                Name = dp.Name,
                Amount = dp.Amount,
                CreatedDate = dp.CreatedDate
            }).AsEnumerable();
            return Task.FromResult(list);
        }

        public Task<UpdateDuePlanDTO> UpdateDuePlanAsync(int id, UpdateDuePlanDTO duePlanDto)
        {
            var duePlan = _context.DuePlans.Find(id);
            if (duePlan == null)
            {
                throw new KeyNotFoundException("Düzenleme Hatası ( 404 )");
            }
            duePlan.BuildingId = duePlanDto.BuildingId;
            duePlan.Name = duePlanDto.Name;
            duePlan.Amount = duePlanDto.Amount;
            _context.DuePlans.Update(duePlan);
            _context.SaveChanges();
            return Task.FromResult(duePlanDto);

        }
    }
}

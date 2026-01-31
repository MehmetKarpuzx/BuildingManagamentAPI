using BuildingManagament.Application.Interfaces;
using BuildingManagament.Domain.Entities;
using BuildingManagament.DTO.ExpenseCategoryDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class ExpenseCategoryServices : IExpenseCategoryServices
    {
        private readonly BuildingManagamentDbContext _context;
        public ExpenseCategoryServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddExpenseCategoryDTO> AddExpenseCategoryAsync(AddExpenseCategoryDTO expenseCategoryDto)
        {
            var entity = new ExpenseCategory
            {
                BuildingId = expenseCategoryDto.BuildingId,
                Name = expenseCategoryDto.Name
            };
            await _context.ExpenseCategories.AddAsync(entity);  
            await _context.SaveChangesAsync();
            return expenseCategoryDto;
        }

        public async Task<IEnumerable<ResponseExpenseCategoryDTO>> GetAllExpenseCategoriesAsync()
        {
            var list = _context.ExpenseCategories.Select(ec => new ResponseExpenseCategoryDTO
            {
                Id = ec.Id,
                BuildingId = ec.BuildingId,
                Name = ec.Name,
                CreatedDate = ec.CreatedDate
            }).AsEnumerable();
            return await Task.FromResult(list); 
        }

        public  async Task<UpdateExpenseCategoryDTO> UpdateExpenseCategoryAsync(int id, UpdateExpenseCategoryDTO expenseCategoryDto)
        {
            var entity = await _context.ExpenseCategories.FindAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException(" 404 ");
            }
            entity.BuildingId = expenseCategoryDto.BuildingId;
            entity.Name = expenseCategoryDto.Name;
            _context.ExpenseCategories.Update(entity);
            await _context.SaveChangesAsync();
            return expenseCategoryDto;

        }
    }
}

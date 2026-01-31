using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.ExpenseDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class ExpenseServices : IExpenseServices
    {
        private readonly BuildingManagamentDbContext _context;
        public ExpenseServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddExpenseDTO> AddExpenseAsync(AddExpenseDTO expenseDto)
        {
            var expense = new BuildingManagament.Domain.Entities.Expense
            {
                BuildingId = expenseDto.BuildingId,
                ExpenseCategoryId = expenseDto.ExpenseCategoryId,
                ExpenseDate = expenseDto.ExpenseDate,
                Amount = expenseDto.Amount,
                Description = expenseDto.Description,
            };
            await _context.Expenses.AddAsync(expense);
            await _context.SaveChangesAsync();
            return expenseDto;
        }

        public Task<IEnumerable<ResponseExpenseDTO>> GetAllExpensesAsync()
        {
            var list = _context.Expenses.Select(e => new ResponseExpenseDTO
            {
                Id = e.Id,
                BuildingId = e.BuildingId,
                ExpenseCategoryId = e.ExpenseCategoryId,
                ExpenseDate = e.ExpenseDate,
                Amount = e.Amount,
                Description = e.Description,
                CreatedDate = e.CreatedDate
            }).AsEnumerable();
            return Task.FromResult(list);

        }

        public Task<UpdateExpenseDTO> UpdateExpenseAsync(int id, UpdateExpenseDTO expenseDto)
        {
           var expense = _context.Expenses.Find(id);
            if (expense == null)
            {
                throw new KeyNotFoundException("Düzenleme Hatası ( 404 )");
            }
            expense.BuildingId = expenseDto.BuildingId;
            expense.ExpenseCategoryId = expenseDto.ExpenseCategoryId;
            expense.ExpenseDate = expenseDto.ExpenseDate;
            expense.Amount = expenseDto.Amount;
            expense.Description = expenseDto.Description;
            _context.Expenses.Update(expense);
            _context.SaveChanges();
            return Task.FromResult(expenseDto);
        }
    }
}

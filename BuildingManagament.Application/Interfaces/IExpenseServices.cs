using BuildingManagament.DTO.ExpenseDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IExpenseServices
    {
        Task<IEnumerable<ResponseExpenseDTO>> GetAllExpensesAsync();
        Task<AddExpenseDTO> AddExpenseAsync(AddExpenseDTO expenseDto);
        Task<UpdateExpenseDTO> UpdateExpenseAsync(int id, UpdateExpenseDTO expenseDto);

    }
}

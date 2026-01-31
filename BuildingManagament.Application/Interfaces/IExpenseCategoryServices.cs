using BuildingManagament.DTO.ExpenseCategoryDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IExpenseCategoryServices
    {
        Task<IEnumerable<ResponseExpenseCategoryDTO>> GetAllExpenseCategoriesAsync();
        Task<AddExpenseCategoryDTO> AddExpenseCategoryAsync(AddExpenseCategoryDTO expenseCategoryDto);
        Task<UpdateExpenseCategoryDTO> UpdateExpenseCategoryAsync(int id, UpdateExpenseCategoryDTO expenseCategoryDto);

    }
}

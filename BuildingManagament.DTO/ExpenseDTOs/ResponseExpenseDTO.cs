using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.ExpenseDTOs
{
    public class ResponseExpenseDTO
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

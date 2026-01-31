using BuildingManagament.Domain.Common;
using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Expense :BaseEntity
    {
        public int BuildingId { get; set; }
        public int ExpenseCategoryId { get; set; }
        public DateTime ExpenseDate { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public PaymentStatus  PaymentStatus { get; set; }

        public Building Building { get; set; } = null!;
        public ExpenseCategory ExpenseCategory { get; set; } = null!;

    }
}

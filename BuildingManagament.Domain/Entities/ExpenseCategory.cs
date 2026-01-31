using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class ExpenseCategory:BaseEntity
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }

        // Navigation
        public Building Building { get; set; } = null!;
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();

    }
}

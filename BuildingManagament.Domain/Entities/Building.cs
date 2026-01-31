using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Building : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Unit> Units { get; set; } = new List<Unit>();
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Meeting> Meetings { get; set; } = new List<Meeting>();
        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
        public ICollection<ExpenseCategory> ExpenseCategories { get; set; } = new List<ExpenseCategory>();
        public ICollection<DuePlan> DuePlans { get; set; } = new List<DuePlan>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    }
}

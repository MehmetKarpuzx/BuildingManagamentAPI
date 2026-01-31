using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Payment :BaseEntity
    {
        public int BuildingId { get; set; }
        public int UnitId { get; set; }
        public int PaidByUserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public Building Building { get; set; } = null!;
        public Unit? Unit { get; set; }
        public User PaidByUser { get; set; } = null!;

    }
}

using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class DuePlan :BaseEntity
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }

        public Building Building { get; set; } = null!;
    }
}

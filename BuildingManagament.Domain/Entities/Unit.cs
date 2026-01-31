using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Unit:BaseEntity
    {
        public int BuildingId { get; set; }   // FK  
        public string Block { get; set; }
        public int FloorNo { get; set; }
        public int DoorNo { get; set; }
        public Building Building { get; set; } = null!;
        public ICollection<User> Users { get; set; } = new List<User>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();

    }
}

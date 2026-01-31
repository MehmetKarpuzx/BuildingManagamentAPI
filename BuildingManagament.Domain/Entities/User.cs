using BuildingManagament.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class User:BaseEntity
    {
        public string TC { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;

        // Login alanları (MVP)
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        // Güvenlik için
        public string? PasswordSalt { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public int RoleId { get; set; }

        public int BuildingId { get; set; }

        // Yönetici vb. için null olabilir
        public int? UnitId { get; set; }

        // Navigation
        public Role Role { get; set; } = null!;
        public Building Building { get; set; } = null!;
        public Unit? Unit { get; set; }

        public ICollection<Vote> Votes { get; set; } = new List<Vote>();
        public ICollection<Payment> PaymentsMade { get; set; } = new List<Payment>();
    }
}

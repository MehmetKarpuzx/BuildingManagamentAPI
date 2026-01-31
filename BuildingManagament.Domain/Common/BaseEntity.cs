using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        // Soft delete
        public bool IsDeleted { get; set; }

        // Audit (istersen kaldırabilirsin ama projede çok işine yarar)
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

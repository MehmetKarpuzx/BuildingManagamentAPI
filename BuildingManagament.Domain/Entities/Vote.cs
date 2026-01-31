using BuildingManagament.Domain.Common;
using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Vote:BaseEntity
    {
   
        public int DecisionId { get; set; }
        public int UserId { get; set; }
        public VoteType VoteType { get; set; }

        // Navigation
        public Decision Decision { get; set; } = null!;
        public User User { get; set; } = null!;

    }
}

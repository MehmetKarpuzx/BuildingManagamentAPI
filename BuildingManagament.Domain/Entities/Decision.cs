using BuildingManagament.Domain.Common;
using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Decision :BaseEntity
    {
        public int MeetingId { get; set; }
        public string DecisionText { get; set; }
        public DecisionType  DecisionType  { get; set; }
        public ResultStatus ResultStatus { get; set; }
        public Meeting Meeting { get; set; } = null!;
        public ICollection<Vote> Votes { get; set; } = new List<Vote>();


    }
}

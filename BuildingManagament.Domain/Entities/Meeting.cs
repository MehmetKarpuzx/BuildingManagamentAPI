using BuildingManagament.Domain.Common;
using BuildingManagament.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingManagament.Domain.Entities
{
    public class Meeting:BaseEntity
    {
        public int BuildingId { get; set; }
        public string Title { get; set; } = null!;
        public DateTime MeetingDateTime { get; set; }
        public string? Location { get; set; }
        public MeetingStatus MeetingStatus { get; set; }
        public int? CalledByUserId { get; set; }
        public string? Result { get; set; }

        // Navigation
        public Building Building { get; set; } = null!;
        public User? CalledByUser { get; set; }

        public ICollection<Decision> Decisions { get; set; } = new List<Decision>();


    }
}

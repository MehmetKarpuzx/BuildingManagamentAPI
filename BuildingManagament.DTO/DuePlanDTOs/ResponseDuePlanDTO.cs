using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.DuePlanDTOs
{
    public class ResponseDuePlanDTO
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Amount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

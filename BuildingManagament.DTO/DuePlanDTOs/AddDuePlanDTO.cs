using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.DuePlanDTOs
{
    public class AddDuePlanDTO
    {
        public int BuildingId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}

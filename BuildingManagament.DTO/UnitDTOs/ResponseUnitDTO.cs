using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.UnitDTOs
{
    public class ResponseUnitDTO
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public string Block { get; set; } = null!;
        public int FloorNo { get; set; }
        public int DoorNo { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

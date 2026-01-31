using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.UnitDTOs
{
    public class UpdateUnitDTO
    {
        public int BuildingId { get; set; }
        public string Block { get; set; }
        public int FloorNo { get; set; }
        public int DoorNo { get; set; }
    }
}

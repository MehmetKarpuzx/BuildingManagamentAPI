using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.DTO.PaymentDTOs
{
    public class ResponsePaymentDTO
    {
        public int Id { get; set; }
        public int BuildingId { get; set; }
        public int UnitId { get; set; }
        public int PaidByUserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

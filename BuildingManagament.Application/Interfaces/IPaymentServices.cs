using BuildingManagament.DTO.PaymentDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Interfaces
{
    public interface IPaymentServices
    {
        Task<IEnumerable<ResponsePaymentDTO>> GetAllPaymentsAsync();
        Task<AddPaymentDTO> AddPaymentAsync(AddPaymentDTO paymentDto);
        Task<UpdatePaymentDTO> UpdatePaymentAsync(int id, UpdatePaymentDTO paymentDto);

    }
}

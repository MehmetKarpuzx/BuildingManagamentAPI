using BuildingManagament.Application.Interfaces;
using BuildingManagament.DTO.PaymentDTOs;
using BuildingManagament.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingManagament.Application.Services
{
    public class PaymentServices : IPaymentServices
    {
        private readonly BuildingManagamentDbContext _context;
        public PaymentServices(BuildingManagamentDbContext context)
        {
            _context = context;
        }
        public async Task<AddPaymentDTO> AddPaymentAsync(AddPaymentDTO paymentDto)
        {
            var payment = new BuildingManagament.Domain.Entities.Payment
            {
                BuildingId = paymentDto.BuildingId,
                UnitId = paymentDto.UnitId,
                PaidByUserId = paymentDto.PaidByUserId,
                PaymentDate = paymentDto.PaymentDate,
                Amount = paymentDto.Amount,
                Description = paymentDto.Description
            };
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            return paymentDto;

        }

        public async Task<IEnumerable<ResponsePaymentDTO>> GetAllPaymentsAsync()
        {
            var list =  _context.Payments.Select(p => new ResponsePaymentDTO
            {
                Id = p.Id,
                BuildingId = p.BuildingId,
                UnitId = p.UnitId,
                PaidByUserId = p.PaidByUserId,
                PaymentDate = p.PaymentDate,
                Amount = p.Amount,
                Description = p.Description,
                CreatedDate = p.CreatedDate
            }).AsEnumerable();
            return await Task.FromResult(list);
        }

        public Task<UpdatePaymentDTO> UpdatePaymentAsync(int id, UpdatePaymentDTO paymentDto)
        {
            var payment =  _context.Payments.Find(id);  
            if (payment == null)
            {
                throw new KeyNotFoundException("404");
            }
            payment.BuildingId = paymentDto.BuildingId;
            payment.UnitId = paymentDto.UnitId;
            payment.Amount = paymentDto.Amount;
            payment.PaymentDate = paymentDto.PaymentDate;
            payment.Description = paymentDto.Description;
            _context.Payments.Update(payment);
            _context.SaveChanges();
            return Task.FromResult(paymentDto);

        }
    }
}

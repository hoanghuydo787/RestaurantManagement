using Abp.Application.Services;
using MyCompanyName.AbpZeroTemplate.Order.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Order
{
    public interface IOrderAppService : IApplicationService
    {
        Task<OrderDto> CreateOrder (OrderDto order);
        Task<OrderDto> UpdateOrder (OrderDto order);
        Task<OrderDto> DeleteOrder (OrderDto order);
        Task<OrderDto> GetOrder (OrderDto order);
        Task<List<OrderDto>> GetAllOrders ();

    }
}

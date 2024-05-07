using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyCompanyName.AbpZeroTemplate.Order.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Order
{
    public class OrderAppService : ApplicationService, IOrderAppService
    {
/*        private readonly IRepository<Order, int> _orderRepository;
        public OrderAppService(IRepository<Order, int> orderRepository)
        {
            this._orderRepository = orderRepository;
        }*/
        public Task<OrderDto> CreateOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> DeleteOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> GetOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public Task<OrderDto> UpdateOrder(OrderDto order)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderDto>> GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}


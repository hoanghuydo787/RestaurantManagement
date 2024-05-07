using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Order;
using MyCompanyName.AbpZeroTemplate.Order.Dto;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Web.Controllers
{
    [Route("/api/v1/order")]
    public class OrderController : Controller
    {
        private readonly IOrderAppService _orderAppService;
        public OrderController(IOrderAppService orderAppService)
        {
            _orderAppService = orderAppService;
        }

        [HttpPost]
        public async Task<OrderDto> CreateOrder (OrderDto order)
        {
            return await _orderAppService.CreateOrder(order);
        }


    }
}

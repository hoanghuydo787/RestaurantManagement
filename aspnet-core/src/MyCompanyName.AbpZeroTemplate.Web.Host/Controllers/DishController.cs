using Microsoft.AspNetCore.Mvc;
using MyCompanyName.AbpZeroTemplate.Dish;
using MyCompanyName.AbpZeroTemplate.Dish.Dto;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Web.Controllers
{
    [Route("/api/v1/dish")]
    public class DishController : Controller
    {
        private readonly IDishAppService _dishAppService;
        public DishController(IDishAppService dishAppService)
        {
            _dishAppService = dishAppService;
        }

        [HttpPost]
        public async Task<DishDto> CreateDish(CreateDishDto dish)
        {
            return await _dishAppService.CreateDish(dish);
        }
    }
}

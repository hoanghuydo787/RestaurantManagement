using Abp.Application.Services;
using MyCompanyName.AbpZeroTemplate.Dish.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Dish
{
    public interface IDishAppService : IApplicationService
    {
        Task<DishDto> CreateDish(CreateDishDto dish);
        Task<DishDto> UpdateDish(DishDto dish);
        Task<DishDto> DeleteDish(DishDto dish);
        Task<DishDto> GetDish(DishDto dish);
    }
}

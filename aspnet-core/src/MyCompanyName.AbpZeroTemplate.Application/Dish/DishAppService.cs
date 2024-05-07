using Abp.Application.Services;
using Abp.Domain.Repositories;
using MyCompanyName.AbpZeroTemplate.Dish.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.Dish
{
    public class DishAppService : ApplicationService, IDishAppService
    {
        private readonly IRepository<Dish, int> _dishRepository;
        public DishAppService(IRepository<Dish, int> dishRepository)
        {
            this._dishRepository = dishRepository;
        }
        public async Task<DishDto> CreateDish(CreateDishDto dish)
        {
            var newDish = new Dish 
            {
                Id = 0,
                Name = "lemon juice",
                Description = "this is the best lemon juice in the world"
            };
            newDish = await _dishRepository.InsertAsync(newDish);
            var newDishDto = ObjectMapper.Map<DishDto>(newDish);
            return newDishDto;
        }

        public Task<DishDto> DeleteDish(DishDto dish)
        {
            throw new NotImplementedException();
        }

        public Task<DishDto> GetDish(DishDto dish)
        {
            throw new NotImplementedException();
        }

        public Task<DishDto> UpdateDish(DishDto dish)
        {
            throw new NotImplementedException();
        }
    }
}

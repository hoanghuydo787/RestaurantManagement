using MyCompanyName.AbpZeroTemplate.Dish.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCompanyName.AbpZeroTemplate.Order.Dto
{
    public class CreateOrderDto
    {
        public List<DishDto> DishList { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

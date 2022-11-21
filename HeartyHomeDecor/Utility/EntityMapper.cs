using AutoMapper;
using HeartyHomeDecor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeartyHomeDecor.Utility
{
    public class EntityMapper : Profile
    {
        public EntityMapper()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
        }
    }
}

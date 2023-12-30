using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.Shop;
using DAL.Models.Shop;

namespace BLL.Services.Shop
{
    public class CategoryService
    {
        public static List<CategoryDTO> Get()
        {
            var data = DataAccessFactory.CategoryData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CategoryDTO>>(data);
        }
        public static bool Add(CategoryDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CategoryDTO, Category>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Category>(c);
            return DataAccessFactory.CategoryData().Create(data);

        }


    }
}

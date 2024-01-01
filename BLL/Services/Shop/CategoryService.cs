using AutoMapper;
using BLL.DTOs.Shop;
using DAL.Models.Shop;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        public static CategoryDTO Get(int id)
        {
            var data = DataAccessFactory.CategoryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CategoryDTO>(data);
            return mapped;
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

        public static CategoryDTO Delete(int id)
        {
            var data = DataAccessFactory.CategoryData().Delete(id);

            return null;
        }

        public static CategoryDTO Update(int id)
        {
            var data = DataAccessFactory.CategoryData().Read(id);



            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<CategoryDTO>(data);
            return mapped;
        }



        public static bool Update(CategoryDTO p)
        {
            var rdata = DataAccessFactory.CategoryData().Read();
            var exdata = DataAccessFactory.CategoryData().Read(p.Id);

            if (exdata != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<CategoryDTO, Category>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<Category>(p);


                return DataAccessFactory.CategoryData().Update(data);
            }


            return false;
        }



    }
}

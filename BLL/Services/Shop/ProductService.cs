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
    public class ProductService
    {


        public static List<ProductDTO> Get()
        {
            var data = DataAccessFactory.ProductData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ProductDTO>>(data);
        }



        public static ProductDTO Get(int id)
        {
            var data = DataAccessFactory.ProductData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Product, ProductDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<ProductDTO>(data);
            return mapped;
        }




        public static bool Add(ProductDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductDTO, Product>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Product>(c);
            return DataAccessFactory.ProductData().Create(data);

        }



        public static ProductDTO Delete(int id)
        {
            var data = DataAccessFactory.ProductData().Delete(id);

            return null;
        }



        public static bool Update(ProductDTO p)
        {
            var rdata = DataAccessFactory.ProductData().Read();
            var exdata = DataAccessFactory.ProductData().Read(p.Id);

            if (exdata != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<ProductDTO, Product>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<Product>(p);

             
                return DataAccessFactory.ProductData().Update(data);
            }

           
            return false;
        }





    }
}

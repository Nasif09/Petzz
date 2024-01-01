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
    public class Order_statusService
    {

        public static List<Order_statusDTO> Get()
        {
            var data = DataAccessFactory.OrderStatusData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order_status, Order_statusDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<Order_statusDTO>>(data);
        }



        public static Order_statusDTO Get(int id)
        {
            var data = DataAccessFactory.OrderStatusData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order_status, Order_statusDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<Order_statusDTO>(data);
            return mapped;
        }




        public static bool Add(Order_statusDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order_statusDTO, Order_status>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Order_status>(c);
            return DataAccessFactory.OrderStatusData().Create(data);

        }

        public static Order_statusDTO Delete(int id)
        {
            var data = DataAccessFactory.OrderStatusData().Delete(id);

            return null;
        }


        public static bool Update(Order_statusDTO p)
        {
            var rdata = DataAccessFactory.OrderStatusData().Read();
            var exdata = DataAccessFactory.OrderStatusData().Read(p.Id);

            if (exdata != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Order_statusDTO, Order_status>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<Order_status>(p);


                return DataAccessFactory.OrderStatusData().Update(data);
            }


            return false;
        }



    }
}

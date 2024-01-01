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
    public class OrderService
    {

        public static List<OrderDTO> Get()
        {
            var data = DataAccessFactory.OrderData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Order,OrderDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<OrderDTO>>(data);
        }



        public static OrderDTO Get(int id)
        {
            var data = DataAccessFactory.OrderData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Order, OrderDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<OrderDTO>(data);
            return mapped;
        }




        public static bool Add(OrderDTO c)
        {

            var exdata= DataAccessFactory.ProductData().Read(c.Product_Id);
            c.Total_Price = c.Quantitiy * exdata.Price;

           





            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderDTO, Order>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Order>(c);
            return DataAccessFactory.OrderData().Create(data);

        }



        public static OrderDTO Delete(int id)
        {
            var data = DataAccessFactory.OrderData().Delete(id);

            return null;
        }

        public static OrderDTO Update(int id,int ID)
        {
           
            var Data = DataAccessFactory.OrderData().Read(id);

            var Data2= DataAccessFactory.OrderStatusData().Read(ID);
            
            Data.Status_Id = ID;
            DataAccessFactory.OrderData().Update(Data);




            if (Data.Status_Id == ID)
                if (Data2.Name == "confirmed")
                {
                    {

                        var productData = DataAccessFactory.ProductData().Read(Data.Product_Id);
                        if (productData != null)
                        {

                            productData.Quantity -= Data.Quantitiy;


                            DataAccessFactory.ProductData().Update(productData);
                        }



                        var config = new MapperConfiguration(cfg =>
                        {
                            cfg.CreateMap<Order, OrderDTO>();
                        });

                        var mapper = new Mapper(config);
                        var updatedOrderDTO = mapper.Map<OrderDTO>(Data);

                        return updatedOrderDTO;
                    }
                }
                else {
                    return null;

                }

            else
            {
                return null;
            }
        }


        }
}

using AutoMapper;
using BLL.DTOs.EXTEND;
using DAL.Models.Shop;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Extend
{
    public class FeedBackService
    {

        public static List<FeedBackDTO> Get()
        {
            var data = DataAccessFactory.FeedBackData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FeedBack, FeedBackDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<FeedBackDTO>>(data);
        }



        public static FeedBackDTO Get(int id)
        {
            var data = DataAccessFactory.FeedBackData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBackDTO>(data);
            return mapped;
        }




        public static bool Add(FeedBackDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<FeedBackDTO, FeedBack>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<FeedBack>(c);
            return DataAccessFactory.FeedBackData().Create(data);

        }

        public static FeedBackDTO Delete(int id)
        {
            var data = DataAccessFactory.FeedBackData().Delete(id);

            return null;
        }

        public static FeedBackDTO Update(int id)
        {
            var data = DataAccessFactory.FeedBackData().Read(id);



            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<FeedBack, FeedBackDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<FeedBackDTO>(data);
            return mapped;
        }



        public static bool Update(FeedBackDTO p)
        {
            var rdata = DataAccessFactory.FeedBackData().Read();
            var exdata = DataAccessFactory.FeedBackData().Read(p.Id);

            if (exdata != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<FeedBackDTO, FeedBack>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<FeedBack>(p);


                return DataAccessFactory.FeedBackData().Update(data);
            }


            return false;
        }
    }
}

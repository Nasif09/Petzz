using AutoMapper;
using BLL.DTOs.Shop;
using DAL.Models.Shop;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTOs.EXTEND;

namespace BLL.Services.Extend
{
    public class SalaryService
    {


        public static List<SalaryDTO> Get()
        {
            var data = DataAccessFactory.SalaryData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<SalaryDTO>>(data);
        }



        public static SalaryDTO Get(int id)
        {
            var data = DataAccessFactory.SalaryData().Read(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SalaryDTO>(data);
            return mapped;
        }




        public static bool Add(SalaryDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SalaryDTO, Salary>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Salary>(c);
            return DataAccessFactory.SalaryData().Create(data);

        }

        public static SalaryDTO Delete(int id)
        {
            var data = DataAccessFactory.SalaryData().Delete(id);

            return null;
        }

        public static SalaryDTO Update(int id)
        {
            var data = DataAccessFactory.SalaryData().Read(id);



            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Salary, SalaryDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<SalaryDTO>(data);
            return mapped;
        }



        public static bool Update(SalaryDTO p)
        {
            var rdata = DataAccessFactory.SalaryData().Read();
            var exdata = DataAccessFactory.SalaryData().Read(p.Id);

            if (exdata != null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<SalaryDTO, Salary>();
                });

                var mapper = new Mapper(config);
                var data = mapper.Map<Salary>(p);


                return DataAccessFactory.SalaryData().Update(data);
            }


            return false;
        }




    }
}

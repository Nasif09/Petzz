using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BranchService
    {
        public static List<BranchDTO> Get()
        {
            var data = DataAccessFactory.BranchData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Branch, BranchDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<BranchDTO>>(data);
        }
        public static bool Add(BranchDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BranchDTO, Branch>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Branch>(c);
            return DataAccessFactory.BranchData().Create(data);

        }
    }
}

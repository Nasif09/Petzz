using AutoMapper;
using BLL.DTOs;
using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RegistrationService
    {
        public static List<RegistrationDTO> Get()
        {
            var data = DataAccessFactory.RegistrationData().Read();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Registration, RegistrationDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<RegistrationDTO>>(data);
        }
        public static bool Add(RegistrationDTO c)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<RegistrationDTO, Registration>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Registration>(c);
            return DataAccessFactory.RegistrationData().Create(data);

        }
    }
}

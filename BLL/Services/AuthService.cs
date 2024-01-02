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
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password, bool isAdmin)
        {
            try
            {
                var role = isAdmin ? "Admin" : "Customer";
                var authenticationResult = DataAccessFactory.AuthData().Authenticate(username, password, role);

                if (authenticationResult)
                {
                    var token = new Token
                    {
                        UID = username,
                        CreatedAt = DateTime.Now,
                        Role = role,
                        TKey = Guid.NewGuid().ToString()
                    };

                    var createdToken = DataAccessFactory.TokenData().Create(token);
                    if (createdToken != null)
                    {
                        var cfg = new MapperConfiguration(c =>
                        {
                            c.CreateMap<Token, TokenDTO>();
                        });

                        var mapper = new Mapper(cfg);
                        return mapper.Map<TokenDTO>(createdToken);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }

            return null;
        }

        public static bool IsTokenvalid(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            if(extk != null && extk.DeletedAt == null)
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var extk = DataAccessFactory.TokenData().Read(tkey);
            extk.DeletedAt  = DateTime.Now;
            if(DataAccessFactory.TokenData().Update(extk) != null)
            {
                return true;
            }
            return false;
        }
    }
}

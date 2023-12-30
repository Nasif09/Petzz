using BLL.DTOs;
using BLL.Services;
using Petzz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace Petzz.Controllers
{
    public class RegistrationController : ApiController
    {
        [HttpGet]
        [Route("api/users")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = RegistrationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/user/create")]
        public HttpResponseMessage Create(RegistrationDTO c)
        {
            try
            {
                var data = RegistrationService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpPost]
        [Route("api/user/login")]
        public HttpResponseMessage Login(Login login)
        {
            try
            {
                var res = AuthService.Authenticate(login.Username, login.Password);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else return Request.CreateResponse(HttpStatusCode.NotFound, new { Message = "User not Found " });
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

    }
}

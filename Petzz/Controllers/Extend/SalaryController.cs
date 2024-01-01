using BLL.DTOs.EXTEND;
using BLL.DTOs.Shop;
using BLL.Services.Extend;
using BLL.Services.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzz.Controllers.Extend
{
    public class SalaryController : ApiController
    {

        [HttpGet]
        [Route("api/Salary")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = SalaryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }





        [HttpGet]
        [Route("api/Salary/{id}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = SalaryService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }




        [HttpPost]
        [Route("api/Salary/create")]
        public HttpResponseMessage Create(SalaryDTO c)
        {
            try
            {
                var data = SalaryService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }






        [HttpDelete]
        [Route("api/Salary/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exdata = SalaryService.Get(Id);
            if (exdata != null)
            {
                try
                {
                    var data = SalaryService.Delete(Id);
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Not Found");
            }
        }




        [HttpPut]
        [Route("api/Salary/update")]
        public HttpResponseMessage Update(SalaryDTO p)
        {
            try
            {
                var data = SalaryService.Update(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}

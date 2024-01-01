using BLL.DTOs.Shop;
using BLL.Services.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzz.Controllers.Shop
{
    public class Order_statusController : ApiController
    {

        [HttpGet]
        [Route("api/Order_status")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = Order_statusService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/Order_status/{id}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = Order_statusService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }






        [HttpPost]
        [Route("api/Order_status/create")]
        public HttpResponseMessage Create(Order_statusDTO c)
        {
            try
            {
                var data = Order_statusService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }






        [HttpDelete]
        [Route("api/Order_status/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exdata = Order_statusService.Get(Id);
            if (exdata != null)
            {
                try
                {
                    var data = Order_statusService.Delete(Id);
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
        [Route("api/Order_status/update")]
        public HttpResponseMessage Update(Order_statusDTO p)
        {
            try
            {
                var data = Order_statusService.Update(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }




    }
}
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
    public class OrderController : ApiController
    {

        [HttpGet]
        [Route("api/Order")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = OrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }






        [HttpGet]
        [Route("api/Order/{id}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = OrderService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }







        [HttpPost]
        [Route("api/Order/create")]
        public HttpResponseMessage Create(OrderDTO c)
        {
            try
            {
                var data = OrderService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }


        [HttpDelete]
        [Route("api/Order/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exdata = OrderService.Get(Id);
            if (exdata != null)
            {
                try
                {
                    var data = OrderService.Delete(Id);
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
        [Route("api/Order/update/{id}/{p}")]
        public HttpResponseMessage Update(int Id,int p)
        {
            var exdata = OrderService.Get(Id);
          
            if (exdata != null)
            {
                try
                {
                    var data = OrderService.Update(Id,p);
                    return Request.CreateResponse(HttpStatusCode.OK, "updated");
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








    }
}

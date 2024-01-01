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
    public class ProductController : ApiController
    {


        [HttpGet]
        [Route("api/Product")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = ProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }




        [HttpGet]
        [Route("api/Product/{id}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = ProductService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }












        [HttpPost]
        [Route("api/Product/create")]
        public HttpResponseMessage Create(ProductDTO c)
        {
            try
            {
                var data = ProductService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpDelete]
        [Route("api/Product/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exdata = ProductService.Get(Id);
            if (exdata != null)
            {
                try
                {
                    var data = ProductService.Delete(Id);
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
        [Route("api/Product/update")]
        public HttpResponseMessage Update(ProductDTO p)
        {
            try
            {
                var data = ProductService.Update(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }



    }
}

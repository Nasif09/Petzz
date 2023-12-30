using BLL.DTOs;
using BLL.DTOs.Shop;
using BLL.Services;
using BLL.Services.Shop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzz.Controllers.Shop
{
    public class CategoryController : ApiController
    {

        [HttpGet]
        [Route("api/Category")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = CategoryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/Category/create")]
        public HttpResponseMessage Create(CategoryDTO c)
        {
            try
            {
                var data = CategoryService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }



    }
}

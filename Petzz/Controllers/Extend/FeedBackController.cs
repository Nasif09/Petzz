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
    public class FeedBackController : ApiController
    {
        [HttpGet]
        [Route("api/Feedback")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = FeedBackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }





        [HttpGet]
        [Route("api/FeedBack/{id}")]
        public HttpResponseMessage Get(int Id)
        {
            try
            {
                var data = FeedBackService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }















        [HttpPost]
        [Route("api/FeedBack/create")]
        public HttpResponseMessage Create(FeedBackDTO c)
        {
            try
            {
                var data = FeedBackService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }






        [HttpDelete]
        [Route("api/FeedBack/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            var exdata = FeedBackService.Get(Id);
            if (exdata != null)
            {
                try
                {
                    var data = FeedBackService.Delete(Id);
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
        [Route("api/FeedBack/update")]
        public HttpResponseMessage Update(FeedBackDTO p)
        {
            try
            {
                var data = FeedBackService.Update(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

    }
}

using BLL.DTOs;
using BLL.Services;
using Petzz.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Services.Description;

namespace Petzz.Controllers
{
    public class RoomController : ApiController
    {
        [Logged(IsAdmin = true)]
        [HttpGet]
        [Route("api/rooms")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = RoomService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Logged(IsAdmin = true)]
        [HttpPost]
        [Route("api/room/create")]
        public HttpResponseMessage Create(RoomDTO c)
        {
            try
            {
                var data = RoomService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Logged(IsAdmin = true)]
        [HttpDelete]
        [Route("api/room/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                bool success = RoomService.Delete(id);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Room deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Room not found or could not be deleted.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [HttpPut]
        [Route("api/room/update/{id}")]
        public HttpResponseMessage Update(int id, RoomDTO updatedRoom)
        {
            try
            {
                bool success = RoomService.Update(id, updatedRoom);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Room updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Room not found or could not be updated.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}

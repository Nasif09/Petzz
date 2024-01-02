using BLL.DTOs;
using BLL.DTOs.Hostel;
using BLL.Services;
using BLL.Services.Hostel;
using Petzz.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzz.Controllers.Hostel
{
    public class BookingController : ApiController
    {
        [Logged(IsAdmin = true)]
        [HttpGet]
        [Route("api/bookings")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = BookingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Logged(IsAdmin = false)] 
        [HttpPost]
        [Route("api/booking/create")]
        public HttpResponseMessage Create(BookingDTO c)
        {
            try
            {
                var data = BookingService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [Logged(IsAdmin = false)]
        [Logged]
        [HttpDelete]
        [Route("api/booking/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                bool success = BookingService.Delete(id);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Booking deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Booking not found or could not be deleted.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Logged(IsAdmin = false)]
        [HttpPut]
        [Route("api/booking/update/{id}")]
        public HttpResponseMessage Update(int id, BookingDTO updatedBooking)
        {
            try
            {
                bool success = BookingService.Update(id, updatedBooking);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Booking updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Booking not found or could not be updated.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [Logged(IsAdmin = false)]
        [HttpGet]
        [Route("api/checkavailability")]
        public HttpResponseMessage CheckAvailability(CheckAvailabilityDTO c)
        {
            try
            {
                var data = BookingService.Checkavailability(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


    }
}

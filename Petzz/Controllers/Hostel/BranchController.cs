using BLL.DTOs;
using BLL.Services;
using Petzz.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Petzz.Controllers
{
    public class BranchController : ApiController
    {
        [Logged(IsAdmin = true)]
        [HttpGet]
        [Route("api/branchs")]
        public HttpResponseMessage All()
        {
            try
            {
                var data = BranchService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Logged(IsAdmin = true)]
        [HttpPost]
        [Route("api/branch/create")]
        public HttpResponseMessage Create(BranchDTO c)
        {
            try
            {
                var data = BranchService.Add(c);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Logged(IsAdmin = true)]
        [HttpDelete]
        [Route("api/branch/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                bool success = BranchService.Delete(id);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Branch deleted successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Branch not found or could not be deleted.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Logged(IsAdmin = true)]
        [HttpPut]
        [Route("api/branch/update/{id}")]
        public HttpResponseMessage Update(int id, BranchDTO updatedBranch)
        {
            try
            {
                bool success = BranchService.Update(id, updatedBranch);

                if (success)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Branch updated successfully.");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "Branch not found or could not be updated.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }


        [HttpGet]
        [Route("api/branch/search/{branchName}")]
        public HttpResponseMessage SearchByName(string branchName)
        {
            try
            {
                var data = BranchService.SearchByName(branchName);

                if (data != null && data.Any())
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, $"No branches found with the name '{branchName}'.");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}

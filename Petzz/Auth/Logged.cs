using BLL.Services;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Petzz.Auth
{
    public class Logged : AuthorizationFilterAttribute
    {
        public bool IsAdmin { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            if (token == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Message = "No Token Supplied" });
            }
            else
            {
                var tokenValue = token.ToString();
                if (!AuthService.IsTokenvalid(tokenValue))
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, new { Message = "Token Invalid or Expired" });
                }
                else
                {
                    var tokenInfo = DataAccessFactory.TokenData().Read(tokenValue);
                    if (tokenInfo != null && CheckRoles(tokenInfo.Role))
                    {
                        base.OnAuthorization(actionContext);
                    }
                    else
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Forbidden, new { Message = "Access Denied. Insufficient Role." });
                    }
                }
            }
        }

        private bool CheckRoles(string userRole)
        {
            if (IsAdmin)
            {
                return userRole == "Admin";
            }
            else
            {
                return userRole == "Customer";
            }
        }
    }

}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller1.Filters
{


    public class CustomAuthFilter : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var authenticated = context.HttpContext.Session.GetString("Autenticated");

            if (string.IsNullOrEmpty(authenticated))
            {

                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(new { controller = "Home", action = "Index" })
                );
            }
        }
    }
}

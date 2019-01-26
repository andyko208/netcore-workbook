using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ToDoApp.Middleware
{
    public class LoggerMiddleware : IMiddleware
    {
        private readonly ILogger<LoggerMiddleware> _logger;
        public LoggerMiddleware(ILogger<LoggerMiddleware> logger)
        {
            _logger = logger;
        }
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            // Change the message, Show the controller name, action, and id if available
            // Only happened when ToDoController is called out
            // _logger.LogError("Middleware!");
            string url = context.Request.Path;  //gets the url link of the webpage, localhost:56967/ToDo(cont. name)/Edit(action)/1(id)
            string[] categories = url.Split("/");   //divides each strings by "/" and puts them in an array
            string cont = "";
            string action = "";
            int id = 0;
            if (categories.Length == 3)
            {
                cont = categories[1];
                action = categories[2];
            }
            if (categories.Length == 4)
            {
                cont = categories[1];
                action = categories[2];
                id = Convert.ToInt32(categories[3]);
            }
            _logger.LogError("Middleware!");                // left it here to find the error message easily
            if(cont == "ToDo" && categories.Length == 3)    // when there is no id
            {
                _logger.LogError("{action = " + action + ", controller = " + cont + "}");
            }
            if (cont == "ToDo" && categories.Length == 4)   // when there is id
            {
                _logger.LogError("{action = " + action + ", controller = " + cont + ", id = " + id + "}");
            }
            await next(context);
        }
    }
}

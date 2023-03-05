using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters
{
    public class MySampleAsyncActionFilterAttribute : Attribute, IAsyncActionFilter
    {
        public readonly string _name;
        public MySampleAsyncActionFilterAttribute(string name)
        {
            _name = name;

        }

        // public Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        // {
        //     throw new NotImplementedException();
        // }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"Action Filter Before Executing {_name}");
            /// <summary>
            /// Write you Own Logics Big Implementation
            /// </summary>
            /// <returns></returns>
            await next();
            Console.WriteLine($"Action Filter  After Executed {_name}");
        }
    }
}
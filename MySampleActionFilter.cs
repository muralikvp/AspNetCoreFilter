using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters
{
    public class MySampleActionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("On Action Executed");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("On Action Executing");
        }
    }
}
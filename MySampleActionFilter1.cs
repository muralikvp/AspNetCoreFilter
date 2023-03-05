using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;


namespace filters
{
    public class MySampleActionFilterAttribute : Attribute,IActionFilter
    {
        private readonly string _name;
        public MySampleActionFilterAttribute(string name)
        {
            _name= name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"On Action Executed - { _name }");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"On Action Executing - { _name }");
        }
    }
}

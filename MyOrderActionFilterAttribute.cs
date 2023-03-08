using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;


namespace filters
{
    public class MyOrderActionFilterAttribute : Attribute,IActionFilter,IOrderedFilter
    {
        private readonly string _name;
        public MyOrderActionFilterAttribute(string name,int order = 0)
        {
            _name= name;
            Order = order;
        }

        public int Order {get;set;}

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"Action Filter -After- { _name }");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"On Action Executing -Before { _name }");
        }
    }
}

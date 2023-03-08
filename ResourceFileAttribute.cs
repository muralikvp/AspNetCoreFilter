using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters
{
    public class ResourceFileAttribute : Attribute,IResourceFilter
    {
        private readonly string _name;
       

        public ResourceFileAttribute(string name)
        {
            this._name = name;
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            Console.WriteLine($"Resource Filter -After- { _name }");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            Console.WriteLine($"Resource Filter -Before- { _name }");
        }
    }
}
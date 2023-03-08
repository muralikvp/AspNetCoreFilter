using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace filters
{
    public class CustomExceptionFilter:IExceptionFilter
    {
        private readonly IHostEnvironment _hostEnvironment;

        public CustomExceptionFilter(IHostEnvironment hostEnvironment) =>
            _hostEnvironment = hostEnvironment;

        public void OnException(ExceptionContext context)
        {
            if (!_hostEnvironment.IsDevelopment())
            {
                // Don't display exception details unless running in Development.
                return;
            }
            Console.WriteLine("Exception thrown");
            context.Result = new ContentResult
            {
                Content = context.Exception.ToString()
            };
        }
    }
}
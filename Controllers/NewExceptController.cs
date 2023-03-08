using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace filters.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [TypeFilter(typeof(CustomExceptionFilter))]
    public class NewExceptController : ControllerBase
    {

         [HttpGet(Name = "DivideNumber")]
        public int DivideNumber()
        {
            int FirstNum =3; 
            int secondNum = 0;
            return FirstNum/secondNum;
        }
    }
}
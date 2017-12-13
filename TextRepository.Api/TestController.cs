using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TextRepository.Api
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "test1", "test2" };
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace unittest.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        
        [HttpGet("{a}/{b}")]

        public IActionResult CalculateSum(int a, int b)
        {
            int sum = a + b;
            string res = "{'sum1' : " + sum + "}";
            Console.WriteLine(res);
            return Ok(res);
        }
    }
}
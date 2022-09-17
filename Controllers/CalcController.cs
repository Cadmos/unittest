using Microsoft.AspNetCore.Mvc;

namespace unittest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        [HttpGet("{a}/{b}")]

        public string CalculateSum(int a, int b)
        {
            int sum = a + b;
            string res = "{'sum' : " + sum + "}";
            Console.WriteLine(res);
            return res;
        }

        [HttpGet("Calc/{a}/{b}")]
        public ActionResult JsonSum(int a, int b)
        {
            int sum = a + b;
            string res = "{'sum' : " + sum + "}";
            Console.WriteLine(res);
            return Ok(res);
        }
    }
}
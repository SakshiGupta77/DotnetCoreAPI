using Microsoft.AspNetCore.Mvc;
namespace EmployeeService.Controllers
{
    [Route("[controller]")]
    public class EmployeeController:ControllerBase
    {
            [HttpGet]
            public string Itemname()
            {
                return "Sakshi";
            }
            [HttpGet("water")]
            public int phnno()
            {
                return 21346;
            }
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
    }
}

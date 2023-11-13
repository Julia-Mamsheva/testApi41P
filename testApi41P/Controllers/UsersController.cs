using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testApi41P.BaseConnection;

namespace testApi41P.Controllers
{
    [Route("api/[controller]/{name}")]
    [ApiController]
    [ApiExplorerSettings(GroupName ="Действия с пользователем")]
    public class UsersController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index(string name) => Ok(db.table.Where(x=>x.nameUser.Contains(name)).ToList());
    }
    /*[Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName ="Действия с пользователем")]
    public class UsersController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpGet]
        public IActionResult Index(string name) => Ok(db.table.ToList());
    }*/
}

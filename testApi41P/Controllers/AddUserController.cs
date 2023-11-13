using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testApi41P.BaseConnection;
using testApi41P.ModelBase;

namespace testApi41P.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Действия с пользователем")]

    public class AddUserController : ControllerBase
    {
        ApplicationContext db = new ApplicationContext();
        [HttpPost]
        public IActionResult Index(User user)
        {
            db.Add(user);
            db.SaveChanges();
            return Ok(user);
        }

    }
}

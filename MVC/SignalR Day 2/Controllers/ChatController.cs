using Microsoft.AspNetCore.Mvc;

namespace SignalR_Day_2.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

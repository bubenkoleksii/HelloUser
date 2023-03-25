using HelloUser.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloUser.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public Task<IActionResult> Index([Bind("Name")] HelloUserModel user)
    {
        return Task.FromResult<IActionResult>(View(user));
    }
}
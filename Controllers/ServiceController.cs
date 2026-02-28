using Microsoft.AspNetCore.Mvc;

public class ServiceController : Controller
{
    public IActionResult Service()
    {
        return View();
    }
}
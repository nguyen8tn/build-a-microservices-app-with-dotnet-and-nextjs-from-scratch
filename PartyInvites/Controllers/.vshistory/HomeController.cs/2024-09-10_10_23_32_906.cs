using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {

        /// I check to see whether there has been a validation problem using the
        /// ModelState.IsValid property in the action method that receives the form data
        if (ModelState.IsValid)
        {
            Repository.AddResponse(guestResponse);
            return View("Thanks.cshtml", guestResponse);
        }
        else
        {
            return View();
        }
    }

    public ViewResult ListResponses()
    {
        return View(Repository.Responses
        .Where(r => r.WillAttend == true));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ThirdPartySample.Models;

namespace ThirdPartySample.Controllers
{
    public class SsoController : Controller
    {
        private readonly ILogger<SsoController> _logger;

        public SsoController(ILogger<SsoController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Webhook(WebhookViewModel model)
        {
            // 1- Get the access token
            var imsApiAccesToken = model.token;
            // 2- Try to get the equivalent user through the api call /Employees/Me (Header: Authorization : Bearer imsApiAccesToken)

            // 3- Try to locate the taken user in your users database, using user's GUID

            // 4- Performs regular authentication procedures, bypasses the normal login page, and redirects the user to the post-login page.

            return View();
        }

    }
}
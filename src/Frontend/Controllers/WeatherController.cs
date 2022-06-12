using Frontend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers;

public class WeatherController : Controller
{
    public async Task<IActionResult> Index()
    {
        using (var client = new HttpClient())
        {
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri("http://api/WeatherForecast");
            var response = await client.SendAsync(request);

            var data = await response.Content.ReadAsStringAsync();

            return View("Index", data);
        }        
    }
}

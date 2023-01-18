using dotnNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnNetCoreApp.Controllers
{
    [ApiController]
    [Route("participent")]
    public class ConferenceController: ControllerBase
    {
     
        public ConferenceController(ILogger<LogInController> logger)
        {
        }

        [HttpGet]
        [Route("all")]
        public async Task<Participant[]> GetdashboardLenderAsync(int id)//I would return with an api response just ran out of time...
        {
         // return all participents from a participent micro service
        }


    }
}
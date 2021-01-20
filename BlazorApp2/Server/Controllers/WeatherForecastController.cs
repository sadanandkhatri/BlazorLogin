using BlazorApp2.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorApp2.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "{'id':'34fe5989a7dc48c995b8e52ddc4f2481','customername':'Customer 3176','customertype':" +
            "'EMR','customerparticipantid':'b0ce65730506544','customerpassword':'Q4P4E2T0I4','fdbpassword':'F4Z5S2A8V2','servicesupported':['NewRx','Provider Upload','Pharmacy Download'],'issftpsupported':true,'sftpurl':" +
            "'http://localhost:7072/api/emr-mock-post','ishttpssupported':true,'httpurl':'http://localhost:7072/api/emr-mock-post','medhistoryhttpurl':null,'httptimeout':10,'systematiccontract':null}",
            "{'id':'34fe5989a7dc48c995b8e52ddc4f2481','customername':'Customer 3176','customertype':" +
            "'EMR','customerparticipantid':'b0ce65730506544','customerpassword':'Q4P4E2T0I4','fdbpassword':'F4Z5S2A8V2','servicesupported':['NewRx','Provider Upload','Pharmacy Download'],'issftpsupported':true,'sftpurl':" +
            "'http://localhost:7072/api/emr-mock-post','ishttpssupported':true,'httpurl':'http://localhost:7072/api/emr-mock-post','medhistoryhttpurl':null,'httptimeout':10,'systematiccontract':null}"
            , "Chilly"
        };

        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {

            var rng = new Random();
           // int id = 1;
            return Enumerable.Range(1, 20).Select(index => new WeatherForecast
            {
                Id = index ,
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }) 
            .ToArray();
        }
    }
}

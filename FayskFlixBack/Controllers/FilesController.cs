using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FayskFlixBack.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public FilesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string[] Get()
        {
            var arquivos = Directory.GetFiles("C:\\blob\\midia");
            List<string> retorno = new List<string>();

            foreach(var arquivo in arquivos)
            {
                retorno.Add(Path.GetFileName(arquivo));
            }

            return retorno.ToArray();
        }
    }
}

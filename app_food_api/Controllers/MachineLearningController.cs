using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace app_food_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MachineLearningController : ControllerBase
    {
        private readonly ILogger<MachineLearningController> _logger;

        public MachineLearningController(ILogger<MachineLearningController> logger)
        {
            _logger = logger;
        }

        [HttpGet] //PROGRAMAR PARAMETROS
        public string GetPrevisao()
        {
            //PROGRAMAR CÓDIGO
            return "O método ainda não retorna a previsao";
        }

        [HttpGet]
        [Route("/Dados")]
        public string ConsultarDados()
        {
            //PROGRAMAR CONSULTA DE DADOS
            return "Este método retorna dados estatísticos";
        }
    }
}

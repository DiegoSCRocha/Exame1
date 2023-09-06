using APITesteLynx.Models;
using Microsoft.AspNetCore.Mvc;


namespace APITesteLynx.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Lynxontroller : Controller
    {
        
        [HttpGet(Name = "GetRandom")]
        public double Get()
        {

            Random rnd = new Random();
            return rnd.NextDouble();

        }

        [HttpPost]
        public async Task<float> PostDTO([FromBody]DTO pDto)
        {

            float resultado;

          


            switch (pDto.operacao)
            {
                case "*": resultado = pDto.PrimeiroValor * pDto.SegundoValor;
                    break;
                case "+": resultado = pDto.PrimeiroValor + pDto.SegundoValor;
                    break;
                case "-":
                    resultado = pDto.PrimeiroValor - pDto.SegundoValor;
                    break;
                case "/":
                    resultado = pDto.PrimeiroValor / pDto.SegundoValor;
                    break;
                default:
                    resultado = pDto.PrimeiroValor + pDto.SegundoValor;              
                  break;
            }


            return resultado;
        }
    }
}

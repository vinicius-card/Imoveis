using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imo.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace imo.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImoveisController : ControllerBase
    {
        public IEnumerable<Imovel> _imovel = new Imovel[] {
                new Imovel()
                {
                ImovelId = 1,
                Local = "Ubatuba-sp",
                DataImovel = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                Tipo = "Casa",
                Valor = 5000000,
                Descricao = "4 dmrs, 3 banheiros, varanda gurme",
                ImagemURL = "casa1.png"
            },
            
                new Imovel()
                {
                ImovelId = 2,
                Local = "Ubatuba-sp",
                DataImovel = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                Tipo = "Casa",
                Valor = 7000000,
                Descricao = "5 dmrs, 3 banheiros, varanda gurme",
                ImagemURL = "casa2.png"
            }

            };
        
        public ImoveisController()
        {
        }

        [HttpGet]
        public IEnumerable<Imovel> Get()
        {
            return _imovel;
        }
        [HttpGet("{id}")]
        public IEnumerable<Imovel> GetById(int id)
        {
            return _imovel.Where(imovel => imovel.ImovelId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "ImoveisController Post";
        }

        [HttpPut("id")]
        public string Put(int id)
        {
            return "ImoveisController Put";
        }

        [HttpDelete("id")]
        public string Delete(int id)
        {
            return "ImoveisController Delete";
        }
    }
}

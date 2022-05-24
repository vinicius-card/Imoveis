using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using imo.api.Data;
using imo.api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace imo.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CidadeController : ControllerBase
    {
        private IEnumerable<Cidade> _cidade;

        private readonly DataContext context;

        public CidadeController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cidade> Get()
        {
            return this.context.Cidades;
        }


        [HttpGet("{id}")]
        public Cidade GetById(int id)
        {
            return this.context.Cidades.FirstOrDefault(cidade => cidade.CidadeId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "CidadesController Post";
        }



        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}

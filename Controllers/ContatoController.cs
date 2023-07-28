using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GenContatos.Context;
using GenContatos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GenContatos.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : Controller
    {
        private readonly AgendaContatoContext _context;

        public ContatoController(AgendaContatoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar (Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }
        [HttpGet("{id}")]
        public IActionResult ObterPorId (int id)
        {
            var contato = _context.Contatos.Find(id);
            if(contato == null)
                return NotFound();

            return Ok (contato);
        }

        [HttpGet("ObterPorNome")]
        public IActionResult ObterPorNome(string nome)
        {
            var contato = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contato);
        }

        [HttpGet("ListaTodos")]
        public IActionResult ListarTodos()
        {
            var contato = _context.Contatos.ToList();
            return Ok(contato);
        }
    }
}
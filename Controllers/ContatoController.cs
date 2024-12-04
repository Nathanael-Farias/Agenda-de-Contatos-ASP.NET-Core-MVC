using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProjetoMVC_DIO.Context;
using ProjetoMVC_DIO.Models;

namespace ProjetoMVC_DIO.Controllers
{
    public class ContatoController : Controller
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
             {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
             }
            return View(contato);
            
        }
    }
}
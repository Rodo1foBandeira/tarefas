using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tarefas.Models;

namespace tarefas.Controllers
{
    public class TarefaController : Controller
    {
        private readonly Context _context;

        public TarefaController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {            
            return View(_context.Tarefas.ToList());
        }

        public IActionResult Form()
        {            
            return View(default(Tarefa));
        }

        [HttpPost]
        public IActionResult SaveUpdate(Tarefa request)
        {
            _context.DbSet<Tarefa>.SaveUpdate(request);
            return RedirectToAction("Index"); 
        }
    }
}
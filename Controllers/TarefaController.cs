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

        public IActionResult Form(int? id)
        {            
            var tarefa = default(Tarefa);
            if (id != null)
            {
                tarefa = _context.Tarefas.Find(id);
            }
            return View(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUpdate(Tarefa request)
        {
            if (request.Id > 0)
            {
                _context.Update(request);
            }
            else
            {
                _context.Add(request);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction("Index"); 
        }
    }
}
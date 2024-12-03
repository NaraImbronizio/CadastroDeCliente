using CadastroDeCliente.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CadastroDeCliente.Controllers
{
    public class Cadastro_Cliente : Controller

    {
        private readonly AppCont _appCont;

        public Cadastro_Cliente(AppCont appCont)
        {
            _appCont = appCont;
        }
        public IActionResult Index()
        {
            var allTasks = _appCont.Tarefas.ToList();
            return View(allTasks);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Cliente = await _appCont.Tarefas
                .FirstOrDefaultAsync(x => x.Id == id);

            if (Cliente == null)
            {
                return BadRequest();
            }

            return View(Cliente);
        }
      
        //GET: Tarefas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cadastro_Cliente Cadastro_Cliente)
        {
            if (ModelState.IsValid)
            {
                _appCont.Add(Cadastro_Cliente);
                await _appCont.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Cadastro_Cliente);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tarefa = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
            if (tarefa == null)
            {
                return BadRequest();
            }
            return View(tarefa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Cadastro_Cliente Cadastro_Cliente)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _appCont.Update(Cadastro_Cliente);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Cadastro_Cliente);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cliente = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tarefa = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
            if (tarefa != null)
            {
                _appCont.Tarefas.Remove(tarefa);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }

    }
}

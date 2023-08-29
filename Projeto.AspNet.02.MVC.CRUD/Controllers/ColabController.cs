using Projeto.AspNet._03.MVC.CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace Projeto.AspNet._03.MVC.CRUD.Controllers
{
    public class ColabController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.TodosOsColabs);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Colab registroColab)
        {
            if(ModelState.IsValid)
            {
                Repository.Inserir(registroColab);
                return View("Agradecimento", registroColab);
            } 
            else
            {
                return View();
            }
        }

        public IActionResult Update(string Identificador)
        {
            Colab consulta = Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First();
            return View(consulta);
        }

        [HttpPost]

        public IActionResult Update(string Identificador, Colab registroAlteradoColab)
        {
            if(ModelState.IsValid)
            {
                Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First().Idade = registroAlteradoColab.Idade;
                Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First().Salario = registroAlteradoColab.Salario;
                Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First().Departamento = registroAlteradoColab.Departamento;
                Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First().Nome = registroAlteradoColab.Nome;
                Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First().Genero = registroAlteradoColab.Genero;

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Delete(string Identificador)
        {
            Colab consulta = Repository.TodosOsColabs.Where((e) => e.Nome == Identificador).First();
            Repository.Excluir(consulta);
            return RedirectToAction("Index");
        }
    }
}

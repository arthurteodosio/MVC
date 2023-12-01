using Microsoft.AspNetCore.Mvc;
using mvcDemo.Models;

namespace mvcDemo.Controllers
{
    public class FuncionariosController : Controller
    {
        private readonly List<Funcionario> funcionarios = new List<Funcionario>();

        public FuncionariosController()
        {
            funcionarios.Add(new Funcionario()
            {
                Nome = "Arthur Sampaio",
                Cargo = "Aprendiz",
                CargaHorária = 6


            });

            funcionarios.Add(new Funcionario()
            {
                Nome = "Anthony Faccioli",
                Cargo = "Estágiario",
                CargaHorária = 8
                
            });
        }

        public IActionResult Index()
        {
            return View(funcionarios);
        }

        public IActionResult Details(string id)
        {
            var funcionario = funcionarios.Find(a => a.Cargo == id);
            if (funcionario == null) return NotFound();

            return View(funcionario);
        }
    }
}

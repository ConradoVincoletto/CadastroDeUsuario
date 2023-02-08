using CadastroDeUsuário.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CadastroDeUsuário.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            Usuário usuário = new Usuário();
            usuário.Nome = "Conrado Vincoletto";
            usuário.Email = "conrado@gmail.com";
            usuário.Endereco = "Rua João Úria, 280";
            usuário.Cidade = "Mococa";

            return View(usuário);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
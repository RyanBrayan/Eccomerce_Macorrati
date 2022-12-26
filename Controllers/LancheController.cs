using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SiteMVC.Models;
using SiteMVC.Repositories.Interfaces;
using SiteMVC.ViewsModels;

namespace SiteMVC.Controllers
{
    public class LancheController : Controller
    {

        private readonly ILancheRepository _lancheRepository;


        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            // ViewData["Titulo"] = "Todos os lanches";
            // ViewData["Data"] = DateTime.Now;

            // var lanches = _lancheRepository.Lanches;


            // var totalLanches = lanches.Count();
            // ViewBag.Total = "Total de lanches: ";
            // ViewBag.TotalLanches = totalLanches;
            // return View(lanches);
            var lanchesListViewModel = new LancheListViewModel();
            lanchesListViewModel.Lanches = _lancheRepository.Lanches;
            lanchesListViewModel.CategoriaAtual = "Categoria Atual";
            return View(lanchesListViewModel);
        }
    }
}
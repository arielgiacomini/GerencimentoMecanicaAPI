using Microsoft.AspNetCore.Mvc;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.ViewModels;
using System;
namespace SGMLoquinho.WebApp.Controllers
{
    [Route("colaboradores")]
    public class RhColaboradoresController : Controller
    {
        private readonly IRhColaboradoresServices _rhColaboradoresServices;
        public RhColaboradoresController(IRhColaboradoresServices rhColaboradoresServices)
        {
            _rhColaboradoresServices = rhColaboradoresServices;
        }

        public IActionResult Index()
        {
            var colaboradores = _rhColaboradoresServices.GetByAll();
            return View(colaboradores);
        }

        [Route("novo")]
        public IActionResult Create()
        {
            var viewModel = new RhColaboradoresViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [Route("novo")]
        //[ValidateAntiForgeryToken]
        public IActionResult Create(RhColaboradoresViewModel model)
        {
            try
            {
                _rhColaboradoresServices.Salvar(model);
                RedirectToAction("Index");
                return Ok();
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        private void FillSelectList(RhColaboradoresViewModel viewModel)
        {

        }
    }
}
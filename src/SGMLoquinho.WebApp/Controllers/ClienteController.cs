using Microsoft.AspNetCore.Mvc;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;

namespace SGMLoquinho.WebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        // GET: Cliente
        public ActionResult Index()
        {
            var cliente = _clienteRepository.GetByAll();
            return View(cliente);
        }

        //// GET: Cleinte/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: Cleinte/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Cleinte/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Cleinte/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Cleinte/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Cleinte/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Cleinte/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
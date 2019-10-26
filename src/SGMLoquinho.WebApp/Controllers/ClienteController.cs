using Microsoft.AspNetCore.Mvc;
using SGMLoquinho.ApplicationServices.Interfaces;

namespace SGMLoquinho.WebApp.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteServices _clienteServices;

        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        public ActionResult Index()
        {
            var cliente = _clienteServices.GetByAll();
            return View(cliente);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServices _clienteServices;

        public ClienteController(IClienteServices clienteServices)
        {
            _clienteServices = clienteServices;
        }

        #region Cliente

        [HttpGet]
        [Route("cliente")]
        public IActionResult GetClientesForAll()
        {
            try
            {
                var clientes = _clienteServices.GetByAll();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("cliente/{clienteId}")]
        public IActionResult GetClientesById(int clienteId)
        {
            try
            {
                var clientes = _clienteServices.GetById(clienteId);
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("cliente")]
        public IActionResult Salvar(ClienteViewModel model)
        {
            try
            {
                _clienteServices.Salvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("cliente/{clienteId}")]
        public IActionResult Atualizar(int clienteId, ClienteViewModel model)
        {
            try
            {
                model.ClienteId = clienteId;
                _clienteServices.Atualizar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        #endregion

        #region ClienteVeiculos

        [HttpGet]
        [Route("cliente/veiculo/paginado/{page}")]
        public IActionResult GetOrcamentosForAllPaginado(int page)
        {
            try
            {
                var count = _clienteServices.GetCount();

                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());

                var pagina = page;
                var clienteVeiculos = _clienteServices.GetByAllPaginado(page);
                return Ok(clienteVeiculos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        #endregion

    }
}
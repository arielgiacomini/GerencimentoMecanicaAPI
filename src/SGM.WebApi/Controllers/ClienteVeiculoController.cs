using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class ClienteVeiculoController : ControllerBase
    {
        private readonly IClienteVeiculoServices _clienteVeiculoServices;

        public ClienteVeiculoController(IClienteVeiculoServices clienteVeiculoServices)
        {
            _clienteVeiculoServices = clienteVeiculoServices;
        }

        [HttpGet]
        [Route("cliente-veiculo/{clienteId}")]
        public IActionResult GetVeiculoClienteByClienteId(int clienteId)
        {
            try
            {
                var clienteVeiculos = _clienteVeiculoServices.GetClienteVeiculoByClienteId(clienteId);
                return Ok(clienteVeiculos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("cliente-veiculo/placa/{placa}")]
        public IActionResult GetVeiculoClienteByPlaca(string placa)
        {
            try
            {
                var clienteVeiculo = _clienteVeiculoServices.GetVeiculoClienteByPlaca(placa);
                return Ok(clienteVeiculo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("cliente-veiculo/id/{clienteVeiculoId}")]
        public IActionResult GetClienteVeiculoByClienteVeiculoId(int clienteVeiculoId)
        {
            try
            {
                var clienteVeiculo = _clienteVeiculoServices.GetVeiculoClienteByClienteVeiculoId(clienteVeiculoId);
                return Ok(clienteVeiculo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("cliente-veiculo")]
        public IActionResult Salvar(ClienteVeiculoViewModel model)
        {
            try
            {
                var clienteVeiculoId = _clienteVeiculoServices.SalvarClienteVeiculo(model);
                return Created("", clienteVeiculoId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("cliente-veiculo/{clienteVeiculoId}")]
        public IActionResult Atualizar(int clienteVeiculoId, ClienteVeiculoViewModel model)
        {
            try
            {
                model.ClienteVeiculoId = clienteVeiculoId;
                _clienteVeiculoServices.AtualizarClienteVeiculo(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("cliente-veiculo/inativar/{clienteVeiculoId}")]
        public IActionResult InativarClienteVeiculo(int clienteVeiculoId)
        {
            try
            {
                _clienteVeiculoServices.InativarClienteVeiculo(clienteVeiculoId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        /*
        [HttpGet]
        [Route("cliente/veiculo/paginado/{page}")]
        public IActionResult GetOrcamentosForAllPaginado(int page)
        {
            try
            {
                var count = _clienteVeiculoServices.GetCount();
        
                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());
        
                var pagina = page;
                var clienteVeiculos = _clienteVeiculoServices.GetByAllPaginado(page);
                return Ok(clienteVeiculos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
        */
    }
}

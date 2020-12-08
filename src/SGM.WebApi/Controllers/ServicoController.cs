using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [Route("SGM")]
    [ApiController]
    [Produces("application/json")]
    public class ServicoController : ControllerBase
    {
        private readonly IServicoServices _servicoServices;

        public ServicoController(IServicoServices servicoServices)
        {
            _servicoServices = servicoServices;
        }

        [HttpGet]
        [Route("servico")]
        public IActionResult GetServicoForAll()
        {
            try
            {
                var servico = _servicoServices.GetServicoByAll();
                return Ok(servico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("servico/ultimos-gerados")]
        public IActionResult GetUltimosServicos(int quantidade)
        {
            try
            {
                var count = _servicoServices.GetServicoCount();

                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());

                var ultimosOrcamentos = _servicoServices.GetUltimosServicos(quantidade);

                return Ok(ultimosOrcamentos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("servico/{servicoId}")]
        public IActionResult GetServicoById(int servicoId)
        {
            try
            {
                var servico = _servicoServices.GetServicoById(servicoId);
                return Ok(servico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("servico/veiculo-cliente/")]
        public IActionResult GetServicoClienteVeiculoId(int clienteVeiculoId)
        {
            try
            {
                var servico = _servicoServices.GetServicoByClienteVeiculoId(clienteVeiculoId);
                return Ok(servico);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("servico")]
        public IActionResult Salvar(ServicoViewModel model)
        {
            try
            {
                var Id = _servicoServices.AtualizarOrSalvar(model);

                if (Id == 0)
                {
                    return Ok();
                }

                return Created("", Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("servico/{servicoId}")]
        public IActionResult Atualizar(int servicoId, ServicoViewModel model)
        {
            try
            {
                model.ServicoId = servicoId;
                _servicoServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("servico/mao-de-obra")]
        public IActionResult SalvarservicoMaodeObra(ServicoMaodeObraViewModel model)
        {
            try
            {
                var Id = _servicoServices.SalvarServicoMaodeObra(model);
                return Created("", Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("servico/peca")]
        public IActionResult SalvarservicoPeca(ServicoPecaViewModel model)
        {
            try
            {
                var Id = _servicoServices.SalvarServicoPeca(model);
                return Created("", Id);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        [Route("servico/mao-de-obra")]
        public IActionResult DeletarservicoMaodeObra(ServicoMaodeObraViewModel model)
        {
            try
            {
                _servicoServices.DeletarServicoMaodeObra(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        [Route("servico/peca")]
        public IActionResult DeletarservicoPeca(ServicoPecaViewModel model)
        {
            try
            {
                _servicoServices.DeletarServicoPeca(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("servico/mao-de-obra/{servicoId}")]
        public IActionResult GetservicoMaodeObraByservicoId(int servicoId)
        {
            try
            {
                var servicoMaodeObra = _servicoServices.GetServicoMaodeObraByServicoId(servicoId);
                return Ok(servicoMaodeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("servico/peca/{servicoId}")]
        public IActionResult GetservicoPecaByservicoId(int servicoId)
        {
            try
            {
                var servicoMaodeObra = _servicoServices.GetServicoPecaByServicoId(servicoId);
                return Ok(servicoMaodeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
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
                var servico = _servicoServices.GetByAll();
                return Ok(servico);
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
                var servico = _servicoServices.GetById(servicoId);
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
                _servicoServices.AtualizarOrSalvar(model);
                return Ok();
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
    }
}
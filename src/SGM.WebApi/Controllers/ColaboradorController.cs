using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class ColaboradorController : ControllerBase
    {
        private readonly IColaboradorServices _colaboradorServices;

        public ColaboradorController(IColaboradorServices colaboradorServices)
        {
            _colaboradorServices = colaboradorServices;
        }

        [HttpGet]
        [Route("colaborador")]
        public IActionResult GetClientesForAll()
        {
            try
            {
                var clientes = _colaboradorServices.GetByAll();
                return Ok(clientes);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("colaborador/{colaboradorId}")]
        public IActionResult GetColaboradorById(int colaboradorId)
        {
            try
            {
                var colaborador = _colaboradorServices.GetById(colaboradorId);
                return Ok(colaborador);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("colaborador/colaborador-login/{colaboradorLogin}")]
        public IActionResult GetColaboradorByColaboradorLogin(string colaboradorLogin)
        {
            try
            {
                var colaborador = _colaboradorServices.GetByColaboradorLogin(colaboradorLogin);
                return Ok(colaborador);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("colaborador")]
        public IActionResult Salvar(ColaboradorViewModel model)
        {
            try
            {
                _colaboradorServices.Salvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("colaborador/{colaboradorId}")]
        public IActionResult Atualizar(int colaboradorId, ColaboradorViewModel model)
        {
            try
            {
                model.ColaboradorId = colaboradorId;
                _colaboradorServices.Atualizar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
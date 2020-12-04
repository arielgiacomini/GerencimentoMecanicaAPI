using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoServices _veiculoServices;

        public VeiculoController(IVeiculoServices veiculoServices)
        {
            _veiculoServices = veiculoServices;
        }

        [HttpGet]
        [Route("veiculo")]
        public IActionResult GetVeiculoForAll()
        {
            try
            {
                var veiculo = _veiculoServices.GetByAll();
                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("veiculo/{veiculoId}")]
        public IActionResult GetVeiculoById(int veiculoId)
        {
            try
            {
                var veiculo = _veiculoServices.GetById(veiculoId);
                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("veiculo/descricao-modelo/")]
        public IActionResult GetVeiculoByModeloDescricao(string descricaoModelo)
        {
            try
            {
                var veiculo = _veiculoServices.GetVeiculoByDescricaoModelo(descricaoModelo);
                return Ok(veiculo);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("veiculo")]
        public IActionResult Salvar(VeiculoViewModel model)
        {
            try
            {
                var veiculoId = _veiculoServices.AtualizarOrSalvar(model);
                return Created("", veiculoId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("veiculo/{veiculoId}")]
        public IActionResult Atualizar(int veiculoId, VeiculoViewModel model)
        {
            try
            {
                model.VeiculoId = veiculoId;
                _veiculoServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("veiculo/inativar/{veiculoId}")]
        public IActionResult InativarVeiculo(int veiculoId)
        {
            try
            {
                _veiculoServices.InativarVeiculo(veiculoId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("veiculo/marca/{marcaId}")]
        public IActionResult GetVeiculosByMarcaId(int marcaId)
        {
            try
            {
                var veiculos = _veiculoServices.GetVeiculosByMarcaId(marcaId);
                return Ok(veiculos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("marca/{marcaId}")]
        public IActionResult GetMarcaId(int marcaId)
        {
            try
            {
                var marca = _veiculoServices.GetMarcaByMarcaId(marcaId);
                return Ok(marca);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("marcas")]
        public IActionResult GetMarcasByAll()
        {
            try
            {
                var marcas = _veiculoServices.GetMarcasByAll();
                return Ok(marcas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
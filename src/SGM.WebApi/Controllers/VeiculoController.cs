﻿using Microsoft.AspNetCore.Mvc;
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
        public IActionResult GetOrcamentosForAll()
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
        public IActionResult GetOrcamentosById(int veiculoId)
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

        [HttpPost]
        [Route("veiculo")]
        public IActionResult Salvar(VeiculoViewModel model)
        {
            try
            {
                _veiculoServices.AtualizarOrSalvar(model);
                return Ok();
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
    }
}
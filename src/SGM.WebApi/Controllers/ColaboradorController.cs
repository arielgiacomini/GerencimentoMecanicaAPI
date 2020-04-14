﻿using Microsoft.AspNetCore.Mvc;
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
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("colaborador/{colaboradorId}")]
        public IActionResult GetClientesById(int colaboradorId)
        {
            try
            {
                var colaborador = _colaboradorServices.GetById(colaboradorId);
                return Ok(colaborador);
            }
            catch (Exception)
            {
                return StatusCode(500);
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
                return StatusCode(500);
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
                return StatusCode(500);
            }
        }
    }
}
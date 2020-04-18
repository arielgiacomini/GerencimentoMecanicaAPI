﻿using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class PecaController : ControllerBase
    {

        private readonly IPecaServices _pecaServices;

        public PecaController(IPecaServices pecaServices)
        {
            _pecaServices = pecaServices;
        }

        [HttpGet]
        [Route("peca")]
        public IActionResult GetOrcamentosForAll()
        {
            try
            {
                var peca = _pecaServices.GetByAll();
                return Ok(peca);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("peca/paginado/{page}")]
        public IActionResult GetPecaForAllPaginado(int page)
        {
            try
            {
                var count = _pecaServices.GetCount();

                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());

                var pagina = page;
                var peca = _pecaServices.GetByAllPaginado(page);
                return Ok(peca);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("peca/{pecaId}")]
        public IActionResult GetPecaById(int pecaId)
        {
            try
            {
                var peca = _pecaServices.GetById(pecaId);
                return Ok(peca);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("peca")]
        public IActionResult Salvar(PecaViewModel model)
        {
            try
            {
                _pecaServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("peca/{pecaId}")]
        public IActionResult Atualizar(int pecaId, PecaViewModel model)
        {
            try
            {
                model.PecaId = pecaId;
                _pecaServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
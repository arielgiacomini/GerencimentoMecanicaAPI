﻿using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class OrcamentoController : ControllerBase
    {
        private readonly IOrcamentoServices _orcamentoServices;

        public OrcamentoController(IOrcamentoServices orcamentoServices)
        {
            _orcamentoServices = orcamentoServices;
        }

        [HttpGet]
        [Route("orcamento")]
        public IActionResult GetOrcamentosForAll()
        {
            try
            {
                var orcamento = _orcamentoServices.GetOrcamentoByAll();
                return Ok(orcamento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("orcamento/{orcamentoId}")]
        public IActionResult GetOrcamentosById(int orcamentoId)
        {
            try
            {
                var orcamento = _orcamentoServices.GetOrcamentoById(orcamentoId);
                return Ok(orcamento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("orcamento")]
        public IActionResult Salvar(OrcamentoViewModel model)
        {
            try
            {
                _orcamentoServices.AtualizarOrSalvar(model);
                return Created("", "");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("orcamento/{orcamentoId}")]
        public IActionResult Atualizar(int orcamentoId, OrcamentoViewModel model)
        {
            try
            {
                model.OrcamentoId = orcamentoId;
                _orcamentoServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("orcamento/mao-de-obra")]
        public IActionResult SalvarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel model)
        {
            try
            {
                _orcamentoServices.SalvarOrcamentoMaodeObra(model);
                return Created("", "");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("orcamento/peca")]
        public IActionResult SalvarOrcamentoPeca(OrcamentoPecaViewModel model)
        {
            try
            {
                _orcamentoServices.SalvarOrcamentoPeca(model);
                return Created("", "");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        [Route("orcamento/mao-de-obra")]
        public IActionResult DeletarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel model)
        {
            try
            {
                _orcamentoServices.DeletarOrcamentoMaodeObra(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpDelete]
        [Route("orcamento/peca")]
        public IActionResult DeletarOrcamentoPeca(OrcamentoPecaViewModel model)
        {
            try
            {
                _orcamentoServices.DeletarOrcamentoPeca(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("orcamento/mao-de-obra/{orcamentoId}")]
        public IActionResult GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId)
        {
            try
            {
                var orcamentoMaodeObra = _orcamentoServices.GetOrcamentoMaodeObraByOrcamentoId(orcamentoId);
                return Ok(orcamentoMaodeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("orcamento/peca/{orcamentoId}")]
        public IActionResult GetOrcamentoPecaByOrcamentoId(int orcamentoId)
        {
            try
            {
                var orcamentoMaodeObra = _orcamentoServices.GetOrcamentoPecaByOrcamentoId(orcamentoId);
                return Ok(orcamentoMaodeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
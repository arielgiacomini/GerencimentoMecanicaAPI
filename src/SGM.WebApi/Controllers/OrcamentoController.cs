using Microsoft.AspNetCore.Mvc;
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
                var orcamento = _orcamentoServices.GetByAll();
                return Ok(orcamento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("orcamento/paginado/{page}")]
        public IActionResult GetOrcamentosForAllPaginado(int page)
        {
            try
            {
                var count = _orcamentoServices.GetCount();

                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());

                var pagina = page;
                var orcamento = _orcamentoServices.GetByAllPaginado(page);
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
                var orcamento = _orcamentoServices.GetById(orcamentoId);
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
                return Ok();
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
    }
}
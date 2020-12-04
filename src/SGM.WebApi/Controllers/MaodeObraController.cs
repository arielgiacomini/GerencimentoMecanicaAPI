using Microsoft.AspNetCore.Mvc;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using System;

namespace SGM.WebApi.Controllers
{
    [ApiController]
    [Route("SGM")]
    [Produces("application/json")]
    public class MaodeObraController : ControllerBase
    {
        private readonly IMaodeObraServices _maodeObraServices;

        public MaodeObraController(IMaodeObraServices maoDeObra)
        {
            _maodeObraServices = maoDeObra;
        }

        [HttpGet]
        [Route("mao-de-obra")]
        public IActionResult GetMaodeObraForAll()
        {
            try
            {
                var maoDeObra = _maodeObraServices.GetMaodeObraByAll();
                return Ok(maoDeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("mao-de-obra/paginado/{page}")]
        public IActionResult GetMaodeObrasForAllPaginado(int page)
        {
            try
            {
                var count = _maodeObraServices.GetMaodeObraCount();

                HttpContext.Response.Headers.Add("X-Total-Count", count.Contagem.ToString());

                var pagina = page;
                var maoDeObra = _maodeObraServices.GetMaodeObraByAllPaginado(page);
                return Ok(maoDeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("mao-de-obra/{maoDeObraId}")]
        public IActionResult GetMaodeObraById(int maoDeObraId)
        {
            try
            {
                var maoDeObra = _maodeObraServices.GetMaodeObraById(maoDeObraId);
                return Ok(maoDeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpGet]
        [Route("mao-de-obra/descricao")]
        public IActionResult GetMaodeObraByDescricao(string descricaoMaodeObra)
        {
            try
            {
                var maoDeObra = _maodeObraServices.GetMaodeObraByDescricao(descricaoMaodeObra);
                return Ok(maoDeObra);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPost]
        [Route("mao-de-obra")]
        public IActionResult Salvar(MaodeObraViewModel model)
        {
            try
            {
                _maodeObraServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("mao-de-obra/{maoDeObraId}")]
        public IActionResult Atualizar(int maoDeObraId, MaodeObraViewModel model)
        {
            try
            {
                model.MaodeObraId = maoDeObraId;
                _maodeObraServices.AtualizarOrSalvar(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }

        [HttpPut]
        [Route("mao-de-obra/inativar/{maoDeObraId}")]
        public IActionResult InativarCliente(int maoDeObraId)
        {
            try
            {
                _maodeObraServices.InativarMaodeObra(maoDeObraId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }
    }
}
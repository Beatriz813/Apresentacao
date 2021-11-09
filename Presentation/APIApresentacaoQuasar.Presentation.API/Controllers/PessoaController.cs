using APIApresentacaoQuasar.Domain.Interfaces.Repository;
using APIApresentacaoQuasar.Domain.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIApresentacaoQuasar.Presentation.API.Controllers
{
    [ApiController]
    [Route("/api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private IPessoaRepository _pessoaRepository;
        public PessoaController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet("todas")]
        public IActionResult TodasPessoas()
        {
            var retorno = _pessoaRepository.ListarTodasPessoas();
            return Ok(retorno);
        }

        [HttpGet("listar-por-periodo")]
        public IActionResult TodasPessoasPorPeriodo([FromQuery] DateTime dataInicial, [FromQuery] DateTime dataFinal)
        {
            var retorno = _pessoaRepository.ListarPessoasPorPeriodo(dataInicial, dataFinal);
            return Ok(retorno);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody]Pessoa pessoa)
        {
            try
            {
                _pessoaRepository.CriarPessoa(pessoa);
                return Ok();
            } catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost("atualizar")]
        public IActionResult Atualizar([FromBody] Pessoa pessoa)
        {
            try
            {
                _pessoaRepository.AtualizarPessoa(pessoa);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

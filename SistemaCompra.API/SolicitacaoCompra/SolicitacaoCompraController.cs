using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaCompra.Application.Produto.Command.AtualizarPreco;
using SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra;
using SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacao;
using System;

namespace SistemaCompra.API.Produto
{
    public class SolicitacaoCompraController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SolicitacaoCompraController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet, Route("solicitacao")]
        public IActionResult ObterSolicitacoes()
        {
            var query = new ObterTodasSolicitacoesQuery();
            var solicitacaoViewModel = _mediator.Send(query);
            return Ok(solicitacaoViewModel);
        }

        [HttpGet, Route("solicitacao/{id}")]
        public IActionResult Obter(Guid id)
        {
            var query = new ObterSolicitacaoQuery() { Id = id };
            var solicitacaoViewModel = _mediator.Send(query);
            return Ok(solicitacaoViewModel);
        }

        [HttpPost, Route("solicitacao/cadastro")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult CadastrarSolicitacao([FromBody] RegistrarCompraCommand registrarSolicitacaoCommand)
        {
            _mediator.Send(registrarSolicitacaoCommand);
            return StatusCode(201);
        }

        [HttpPut, Route("solicitacao/atualiza-preco")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult AtualizarPreco([FromBody] AtualizarPrecoCommand atualizarPrecoCommand)
        {
             _mediator.Send(atualizarPrecoCommand);
            return Ok();

        }
    }
}

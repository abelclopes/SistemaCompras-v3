using AutoMapper;
using MediatR;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacao
{
    public class ObterSolicitacaoQueryHandler : IRequestHandler<ObterSolicitacaoQuery, ObterSolicitacaoQueryHandler>
    {
        private readonly ISolicitacaoCompraRepository _solicitacaoCompraRepository;
        private readonly IMapper _mapper;

        public ObterSolicitacaoQueryHandler(ISolicitacaoCompraRepository solicitacaoCompraRepository, IMapper mapper)
        {
            _solicitacaoCompraRepository = solicitacaoCompraRepository;
            _mapper = mapper;
        }
        public Task<ObterSolicitacaoQueryHandler> Handle(ObterSolicitacaoQuery request, CancellationToken cancellationToken)
        {
            var solicitacao = _solicitacaoCompraRepository.Obter(request.Id);
            var produtoViewModel = _mapper.Map<ObterSolicitacaoQueryHandler>(solicitacao);

            return Task.FromResult(produtoViewModel);
        }
    }
}

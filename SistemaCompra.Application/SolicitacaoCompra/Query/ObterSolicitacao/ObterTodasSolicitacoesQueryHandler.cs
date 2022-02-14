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
    public class ObterTodasSolicitacoesQueryHandler : IRequestHandler<ObterTodasSolicitacoesQuery, IList<ObterSolicitacaoViewModel>>
    {
        private readonly ISolicitacaoCompraRepository _solicitacaoCompraRepository;
        private readonly IMapper _mapper;

        public ObterTodasSolicitacoesQueryHandler(ISolicitacaoCompraRepository solicitacaoCompraRepository, IMapper mapper)
        {
            _solicitacaoCompraRepository = solicitacaoCompraRepository;
            _mapper = mapper;
        }
        public Task<IList<ObterSolicitacaoViewModel>> Handle(ObterTodasSolicitacoesQuery request, CancellationToken cancellationToken)
        {
            var solicitacao = _solicitacaoCompraRepository.ObterSolicitacoes();
            var solicitacaoViewModel = _mapper.Map<IList<ObterSolicitacaoViewModel>>(solicitacao);

            return Task.FromResult(solicitacaoViewModel);
        }

    }
}

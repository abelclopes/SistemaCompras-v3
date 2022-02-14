using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacao
{
    public class ObterTodasSolicitacoesQuery : IRequest<IList<ObterSolicitacaoViewModel>>
    {
        public Guid Id { get; set; }
    }
}

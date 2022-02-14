using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Application.SolicitacaoCompra.Query.ObterSolicitacao
{
    public class ObterSolicitacaoQuery : IRequest<ObterSolicitacaoQueryHandler>
    {
        public Guid Id { get; set; }
    }
}

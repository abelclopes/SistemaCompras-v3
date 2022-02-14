using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaCompra.Domain.SolicitacaoCompraAggregate
{
    public interface ISolicitacaoCompraRepository
    {
        IList<SolicitacaoCompra> ObterSolicitacoes();
        void RegistrarCompra(SolicitacaoCompra solicitacaoCompra);
        SolicitacaoCompra Obter(Guid id);
        void Atualizar(SolicitacaoCompra entity);
        void Excluir(SolicitacaoCompra entity);
    }
}

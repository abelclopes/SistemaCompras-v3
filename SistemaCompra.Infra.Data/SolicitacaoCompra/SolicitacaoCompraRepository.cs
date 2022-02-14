
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using SolicitacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
    public class SolicitacaoCompraRepository : ISolicitacaoCompraRepository
    {
        private readonly SistemaCompraContext context;

        public SolicitacaoCompraRepository(SistemaCompraContext context)  {
            this.context = context;
        }

        public void Atualizar(SolicitacaoCompraAgg.SolicitacaoCompra entity)
        {
            context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Update(entity);
        }

        public void Excluir(SolicitacaoCompraAgg.SolicitacaoCompra entity)
        {
            context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Remove(entity);
        }

        public IList<SolicitacaoCompraAgg.SolicitacaoCompra> ObterSolicitacoes()
        {
            return context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().ToList();
        }
        public SolicitacaoCompraAgg.SolicitacaoCompra Obter(Guid id)
        {
            return context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Where(c => c.Id == id).FirstOrDefault();
        }

        public void RegistrarCompra(SolicitacaoCompraAgg.SolicitacaoCompra solicitacaoCompra)
        {
            context.Set<SolicitacaoCompraAgg.SolicitacaoCompra>().Add(solicitacaoCompra);
        }
    }
}

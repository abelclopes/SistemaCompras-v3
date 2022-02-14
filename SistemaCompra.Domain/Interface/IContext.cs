using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCompra.Domain.Interface
{
    public interface IContext
    {
        DbSet<ProdutoAgg.Produto> Produtos { get; set; }
        DatabaseFacade Database { get; }
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}

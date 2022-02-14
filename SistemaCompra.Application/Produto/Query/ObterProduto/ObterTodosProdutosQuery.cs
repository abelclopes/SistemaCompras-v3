using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Application.Produto.Query.ObterProduto
{
    public class ObterTodosProdutosQuery : IRequest<IList<ObterProdutoViewModel>>
    {
        public Guid Id { get; set; }

    }
}

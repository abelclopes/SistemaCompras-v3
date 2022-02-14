using AutoMapper;
using MediatR;
using SistemaCompra.Domain.ProdutoAggregate;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Application.Produto.Query.ObterProduto
{
    public class ObterTodosProdutosQueryHandler : IRequestHandler<ObterTodosProdutosQuery, IList<ObterProdutoViewModel>>
    {
        private readonly IProdutoRepository produtoRepository;
        private readonly IMapper mapper;

        public ObterTodosProdutosQueryHandler(IProdutoRepository produtoRepository, IMapper mapper)
        {
            this.produtoRepository = produtoRepository;
            this.mapper = mapper;
        }

        public Task<IList<ObterProdutoViewModel>> Handle(ObterTodosProdutosQuery request, CancellationToken cancellationToken)
        {
            var produto = produtoRepository.ObterProdutos();
            var produtoViewModel = mapper.Map<IList<ObterProdutoViewModel>>(produto);

            return Task.FromResult(produtoViewModel);
        }
    }
}

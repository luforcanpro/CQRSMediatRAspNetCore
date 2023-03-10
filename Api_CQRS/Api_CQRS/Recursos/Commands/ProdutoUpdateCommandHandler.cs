using Api_CQRS.Context;
using Api_CQRS.Models;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Api_CQRS.Recursos.Commands
{
    public class ProdutoUpdateCommandHandler : IRequestHandler<ProdutoUpdateCommand, Produto>
    {
        private readonly AppDbContext _context;

        public ProdutoUpdateCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Produto> Handle(ProdutoUpdateCommand request, CancellationToken cancellationToken)
        {
            var produto = _context.Produtos.Where(a => a.Id == request.Id).FirstOrDefault();
            if (produto == null)
            {
                return default;
            }
            else
            {
                produto.CodigoBarras = request.CodigoBarras;
                produto.Nome = request.Nome;
                produto.Preco = request.Preco;
                produto.Taxa = request.Taxa;
                produto.Descricao = request.Descricao;
                await _context.SaveChangesAsync();
                return produto;
            }
        }
    }
}

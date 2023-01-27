using Api_CQRS.Context;
using Api_CQRS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Api_CQRS.Recursos.Queries
{
    public class GetProdutoPorIdQueryHandler : IRequestHandler<GetProdutoPorIdQuery, Produto>
    {
        private readonly AppDbContext _context;

        public GetProdutoPorIdQueryHandler(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Produto> Handle(GetProdutoPorIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        }
    }
}

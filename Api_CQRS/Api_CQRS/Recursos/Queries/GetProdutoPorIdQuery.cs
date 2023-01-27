using Api_CQRS.Models;
using MediatR;

namespace Api_CQRS.Recursos.Queries
{
    public class GetProdutoPorIdQuery : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}

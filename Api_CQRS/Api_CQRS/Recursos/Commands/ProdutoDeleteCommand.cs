using Api_CQRS.Models;
using MediatR;

namespace Api_CQRS.Recursos.Commands
{
    public class ProdutoDeleteCommand : IRequest<Produto>
    {
        public int Id { get; set; }
    }
}

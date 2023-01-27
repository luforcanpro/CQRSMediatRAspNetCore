using Api_CQRS.Models;
using MediatR;
using System.Collections.Generic;

namespace Api_CQRS.Recursos.Queries
{
    public class GetTodosProdutosQuery : IRequest<IEnumerable<Produto>>
    {
    }
}


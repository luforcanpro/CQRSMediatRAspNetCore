using Api_CQRS.Models;
using MediatR;

namespace Api_CQRS.Recursos.Commands
{
    public class ProdutoUpdateCommand : IRequest<Produto>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CodigoBarras { get; set; }
        public bool Ativo { get; set; } = true;
        public string Descricao { get; set; }
        public decimal Taxa { get; set; }
        public decimal Preco { get; set; }
    }
}

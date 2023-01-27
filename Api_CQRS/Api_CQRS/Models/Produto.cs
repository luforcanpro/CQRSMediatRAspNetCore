using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_CQRS.Models
{
    public class Produto
    {
        //public Produto(string nome, string codigobarras, string descricao, decimal taxa, decimal preco)
        //{
        //    Nome = nome;
        //    CodigoBarras = codigobarras;
        //    Descricao = descricao;
        //    Taxa = taxa;
        //    preco = Preco.ToStrin
        //}
        public int Id { get; set; }

        [StringLength(80, MinimumLength= 4)]
        public string Nome { get;  set; }

        public string CodigoBarras { get; set; }
        public bool Ativo { get; private set; } = true;

        [StringLength(200, MinimumLength = 4)]
        public string Descricao { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Taxa { get;  set; }
        
        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get;  set; }
    }
}

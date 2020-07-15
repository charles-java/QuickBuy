using System;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using QuickBuy.Dominio.ObjetoDeValor;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
 
        public FormaPagamento formaPagamento { get; set; }

        /// <summary>
        /// pedido deve ter pelo menos um item de pedido ou varios itens.
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void validate()
        {
            LimparMensagemValidacao();


            if (ItensPedido.Any())
                AdicionarCritica("Crítica: Pedido Deve ter Itens");

            if (string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica: CEP e necessário");

        }
    }
}

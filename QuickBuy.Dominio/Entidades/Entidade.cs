using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade   //  classe pai e não pode ser instanciada
    {
        public List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao
        {
            get{ return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());
            }
        }

        public abstract void validate();

        protected bool Ehvalido
        {
            get
            {
                return MensagemValidacao.Any(); 
            }
        }

        public void LimparMensagemValidacao()
        {
            MensagemValidacao.Clear();
        }

        public void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);


        }
            
    }
}

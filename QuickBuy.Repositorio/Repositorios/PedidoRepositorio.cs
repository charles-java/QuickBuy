using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;


namespace QuickBuy.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IProdutoRepositorio
    {
        public void Adicionar(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Produto entity)
        {
            throw new NotImplementedException();
        }

        public void Remover(Produto entity)
        {
            throw new NotImplementedException();
        }

        Produto IbaseRepositorio<Produto>.ObterPorID(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Produto> IbaseRepositorio<Produto>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

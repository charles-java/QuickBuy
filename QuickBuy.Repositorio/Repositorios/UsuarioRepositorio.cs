using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Contratos;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        internal void Adicionar(object usuario)
        {
            throw new NotImplementedException();
        }
    }
}

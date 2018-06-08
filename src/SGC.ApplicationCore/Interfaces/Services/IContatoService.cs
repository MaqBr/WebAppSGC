using SGC.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.ApplicationCore.Interfaces.Services
{
    public interface IContatoService
    {
        Contato Adicionar(Contato entity);
        void Atualizar(Contato entity);
        IEnumerable<Contato> ObterTodos();
        Contato ObterPorId(int id);
        IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado);
        void Remover(Contato entity);
    }
}

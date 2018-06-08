using SGC.ApplicationCore.Entity;
using SGC.ApplicationCore.Interfaces.Repository;
using SGC.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.ApplicationCore.Services
{
    public class ContatoService : IContatoService
    {

        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public Contato Adicionar(Contato entity)
        {
            //TODO: Adicionar regra de negócio
            return _contatoRepository.Adicionar(entity);
              
        }

        public void Atualizar(Contato entity)
        {
            _contatoRepository.Atualizar(entity);
        }

        public IEnumerable<Contato> Buscar(Expression<Func<Contato, bool>> predicado)
        {
            return _contatoRepository.Buscar(predicado);
        }

        public Contato ObterPorId(int id)
        {
            return _contatoRepository.ObterPorId(id);
        }

        public IEnumerable<Contato> ObterTodos()
        {
            return _contatoRepository.ObterTodos();
        }

        public void Remover(Contato entity)
        {
            _contatoRepository.Remover(entity);
        }
    }
}

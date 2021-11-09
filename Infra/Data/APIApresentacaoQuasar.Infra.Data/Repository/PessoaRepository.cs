using APIApresentacaoQuasar.Domain.Interfaces.Repository;
using APIApresentacaoQuasar.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIApresentacaoQuasar.Infra.Data.Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private DBSqlContext _context;
        public PessoaRepository(DBSqlContext context)
        {
            _context = context;
        }
        public Pessoa AtualizarPessoa(Pessoa pessoa)
        {
            _context.Pessoa.Update(pessoa);
            _context.SaveChanges();
            return pessoa;
        }

        public void CriarPessoa(Pessoa pessoa)
        {
            _context.Pessoa.Add(pessoa);
            _context.SaveChanges();
        }

        public ICollection<Pessoa> ListarPessoasPorPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            return _context.Pessoa.Where(p => p.DataInicio >= dataInicial && p.DataFIm <= dataFinal).ToList();
        }

        public ICollection<Pessoa> ListarTodasPessoas()
        {
            return _context.Pessoa.ToList();
        }

        public Pessoa ResgatarPessoaPorCPF(long cpf)
        {
            return _context.Pessoa.Where(p => p.cpf == cpf).FirstOrDefault();
        }
    }
}

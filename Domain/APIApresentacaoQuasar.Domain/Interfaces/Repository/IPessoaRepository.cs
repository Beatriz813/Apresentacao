using APIApresentacaoQuasar.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIApresentacaoQuasar.Domain.Interfaces.Repository
{
    public interface IPessoaRepository
    {
        public void CriarPessoa(Pessoa pessoa);
        public Pessoa AtualizarPessoa(Pessoa pessoa);
        public Pessoa ResgatarPessoaPorCPF(long cpf);
        public ICollection<Pessoa> ListarTodasPessoas();
        public ICollection<Pessoa> ListarPessoasPorPeriodo(DateTime dataInicial, DateTime dataFinal);
    }
}

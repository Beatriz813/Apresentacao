using System;
using System.Collections.Generic;
using System.Text;

namespace APIApresentacaoQuasar.Domain.Model
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public long cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFIm { get; set; }
    }
}

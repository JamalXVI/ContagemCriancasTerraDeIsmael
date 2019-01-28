using ContagemCriancas.Enums;
using System;
using System.Collections.Generic;

namespace ContagemCriancas.Models
{
    //TODO: Relacionar com o Banco de Dados e Fazer Validações
    public class Pessoa : EntidadeBase
    {
        public int Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public bool Ativo { get; set; }
        public List<Turma> Turmas { get; set; }
        public List<PresencaPessoaTurma> Presencas { get; set; }
        public List<Foto> Foto { get; set; }
    }
}
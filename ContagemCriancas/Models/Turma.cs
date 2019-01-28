using System;
using System.Collections.Generic;

namespace ContagemCriancas.Models
{
    //TODO: Relacionar com o Banco de Dados e Fazer Validações
    public class Turma : EntidadeBase
    {
        public string Nome { get; set; }

        public DateTime HorarioFuncionamento { get; set; }

        public int DiaDaSemana { get; set; }

        public bool Ativo { get; set; }

        public List<Pessoa> Pessoas { get; set; }
    }
}
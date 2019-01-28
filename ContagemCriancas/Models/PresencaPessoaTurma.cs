using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContagemCriancas.Models
{
    //TODO: Relacionar com o Banco de Dados e Fazer Validações
    public class PresencaPessoaTurma
    {
        public Turma Turma { get; set; }
        public Pessoa Pessoa { get; set; }
        public Presenca Presenca { get; set; }
        public bool Presente { get; set; }
    }
}
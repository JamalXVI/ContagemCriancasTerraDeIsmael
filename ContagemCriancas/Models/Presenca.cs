using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContagemCriancas.Models
{
    //TODO: Relacionar com o Banco de Dados e Fazer Validações
    public class Presenca : EntidadeBase
    {
        public DateTime Data { get; set; }
        public List<PresencaPessoaTurma> Presencas { get; set; }
    }
}
using System.Collections.Generic;

namespace ContagemCriancas.Dto.output
{
    public class OutputPessoaDto : PessoaDto
    {
        public bool Ativo { get; set; }
        public List<string> Presencas { get; set; }
        public string Foto { get; set; }
    }
}
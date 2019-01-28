using System.Collections.Generic;

namespace ContagemCriancas.Dto.output
{
    public class OutputTurmaDto : TurmaDto
    {
        public List<PessoaDto> Pessoas { get; set; }
    }
}
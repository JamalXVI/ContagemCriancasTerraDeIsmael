using System.Collections.Generic;

namespace ContagemCriancas.Dto
{
    public class OutputPresencaDto
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public List<OutputPresencaPessoaTurmaDto> Presencas { get; set; }
    }
}
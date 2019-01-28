using System.Collections.Generic;

namespace ContagemCriancas.Dto
{
    public class PresencaDto
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public List<PresencaPessoaTurmaDto> Presencas { get; set; }
    }
}
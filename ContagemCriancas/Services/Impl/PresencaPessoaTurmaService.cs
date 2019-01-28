using ContagemCriancas.Dto;
using ContagemCriancas.Models;

namespace ContagemCriancas.Services.Impl
{
    public class PresencaPessoaTurmaService : IPresencaPessoaTurmaService
    {
        public PresencaPessoaTurma Salvar(PresencaPessoaTurmaDto presencaPessoaTurmaDto)
        {
            PresencaPessoaTurma presencaPessoaTurma = new PresencaPessoaTurma();
            //TODO buscar pessoa pelo id
            Pessoa pessoa = null;
            //TODO buscar turma pelo id
            Turma turma = null;
            //TODO buscar Presença pelo Id
            Presenca presenca = null;
            presencaPessoaTurma.Pessoa = pessoa;
            presencaPessoaTurma.Turma = turma;
            presencaPessoaTurma.Presenca = presenca;
            presencaPessoaTurma.Presente = presencaPessoaTurmaDto.Presente;
            //TODO Salvar no banco de dados
            //TODO Retornar Presença
            return presencaPessoaTurma;
        }
    }
}
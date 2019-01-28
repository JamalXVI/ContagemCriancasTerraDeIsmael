using ContagemCriancas.Dto;
using ContagemCriancas.Models;

namespace ContagemCriancas.Services
{
    interface IPresencaPessoaTurmaService
    {
        PresencaPessoaTurma Salvar(PresencaPessoaTurmaDto presencaPessoaTurmaDto);
    }
}

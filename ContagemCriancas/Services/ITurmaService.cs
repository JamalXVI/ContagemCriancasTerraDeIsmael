using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using System.Collections.Generic;

namespace ContagemCriancas.Services
{
    public interface ITurmaService
    {
        string Salvar(TurmaDto turmaDto);

        List<TurmaDto> Listar();

        OutputTurmaDto PesquisarPorId(int id);
    }
}
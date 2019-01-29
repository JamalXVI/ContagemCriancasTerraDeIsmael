using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using ContagemCriancas.Models;
using ContagemCriancas.Utils;
using System.Collections.Generic;

namespace ContagemCriancas.Services.Impl
{
    public class TurmaService : ITurmaService
    {

        public string Salvar(TurmaDto turmaDto)
        {
            Turma turma = new Turma();
            turma.Nome = turmaDto.Nome;
            turma.HorarioFuncionamento = DataUtils.FormartarSomenteHora(turmaDto.Horario);
            turma.DiaDaSemana = turmaDto.DiaDaSemana;
            //TODO Salvar no banco de dados
            //TODO Retornar Informação para a view
            return "";
        }
        public List<TurmaDto> Listar()
        {
            //TODO retornar todas as turmas, apenas as ativas
            List<Turma> turmas = null;
            List<TurmaDto> turmasDto = turmas.Converter();
            return turmasDto;
        }

        public OutputTurmaDto PesquisarPorId(int id)
        {
            //TODO Encontrar a turma específica pelo Id
            Turma turma = null;
            OutputTurmaDto turmaDto = turma.Converter();
            return turmaDto;
        }
    }
}
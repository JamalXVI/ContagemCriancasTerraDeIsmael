using System.Collections.Generic;
using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using ContagemCriancas.Models;
using ContagemCriancas.Utils;

namespace ContagemCriancas.Services.Impl
{
    public class TurmaService : ITurmaService
    {

        public string Salvar(TurmaDto turmaDto)
        {
            Turma turma = new Turma();
            turma.Nome = turmaDto.Nome ;
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
            List<TurmaDto> turmasDto = ConverterUtils.Converter(turmas);
            return turmasDto;
        }

        public OutputTurmaDto PesquisarPorId(int id)
        {
            //TODO Encontrar a turma específica pelo Id
            Turma turma = null;
            OutputTurmaDto turmaDto = ConverterUtils.Converter(turma);
            return turmaDto;
        }
    }
}
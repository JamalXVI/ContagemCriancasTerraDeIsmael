using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using ContagemCriancas.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContagemCriancas.Utils
{
    public static class ConverterUtils
    {
        #region Métodos Públicos
        #region Pessoa
        public static List<PessoaDto> Converter(List<Pessoa> pessoas)
        {
            List<PessoaDto> pessoasDto = (from pessoa in pessoas select CriarPessoaDto(pessoa)).ToList();
            return pessoasDto;
        }

        public static OutputPessoaDto Converter(Pessoa pessoa)
        {

            OutputPessoaDto pessoaDto = new OutputPessoaDto();
            DefinirDadosDePessoaComum(pessoa, pessoaDto);
            pessoaDto.Ativo = pessoa.Ativo;
            pessoaDto.Presencas = (from p in pessoa.Presencas where p.Presente select DataUtils.ConverterDataParaString(p.Presenca.Data)).ToList();
            //TODO Converter Foto para Base64 e Definir no Dto para Enviar a partir do caminho
            return pessoaDto;
        }
        #endregion
        #region Turma
        public static OutputTurmaDto Converter(Turma turma)
        {
            OutputTurmaDto turmaDto = new OutputTurmaDto();
            DefinirComumTurma(turma, turmaDto);
            turmaDto.Pessoas = (from pessoa in turma.Pessoas select CriarPessoaDto(pessoa)).ToList();
            return turmaDto;
        }

        public static List<TurmaDto> Converter(List<Turma> turmas)
        {
            List<TurmaDto> turmasDto = (from turma in turmas select CriarTurmaDto(turma)).ToList();
            return turmasDto;
        }
        #endregion
        #region Presenca

        public static List<OutputPresencaDto> Converter(List<Presenca> presencas)
        {
            List<OutputPresencaDto> presencasDto = (from presenca in presencas select CriarPresencaDto(presenca)).ToList();
            return presencasDto;
        }
        #endregion
        #endregion
        #region Métodos Privados
        #region Pessoa
        private static PessoaDto CriarPessoaDto(Pessoa pessoa)
        {
            PessoaDto pessoaDto = new PessoaDto();
            DefinirDadosDePessoaComum(pessoa, pessoaDto);
            return pessoaDto;
        }
        private static void DefinirDadosDePessoaComum(Pessoa pessoa, PessoaDto pessoaDto)
        {
            pessoaDto.Id = pessoa.Id;
            pessoaDto.Nome = pessoa.Nome;
            pessoaDto.Sobrenome = pessoa.Sobrenome;
            if (pessoa.DataDeNascimento != null)
            {
                pessoaDto.DataDeNascimento = DataUtils.ConverterDataParaString(pessoa.DataDeNascimento);
            }
        }
        #endregion
        #region Turma
        private static TurmaDto CriarTurmaDto(Turma turma)
        {
            TurmaDto turmaDto = new TurmaDto();
            return DefinirComumTurma(turma, turmaDto);
        }

        private static TurmaDto DefinirComumTurma(Turma turma, TurmaDto turmaDto)
        {
            turmaDto.Id = turma.Id;
            turmaDto.Nome = turma.Nome;
            turmaDto.DiaDaSemana = turma.DiaDaSemana;
            turmaDto.Horario = DataUtils.ConverterHoraParaString(turma.HorarioFuncionamento);
            return turmaDto;
        }
        #endregion
        #region Presenca
        private static OutputPresencaDto CriarPresencaDto(Presenca presenca)
        {
            OutputPresencaDto presencaDto = new OutputPresencaDto();
            return DefinirComumPresenca(presencaDto, presenca);
        }

        private static OutputPresencaDto DefinirComumPresenca(OutputPresencaDto presencaDto, Presenca presenca)
        {
            presencaDto.Data = DataUtils.ConverterDataParaString(presenca.Data);
            presencaDto.Presencas = (from presencaPessoaTurma in presenca.Presencas select CriarPresencaPessoaTurmaDto(presencaPessoaTurma)).ToList();
            return presencaDto;
        }
        private static OutputPresencaPessoaTurmaDto CriarPresencaPessoaTurmaDto(PresencaPessoaTurma presencaPessoaTurma)
        {
            OutputPresencaPessoaTurmaDto output = new OutputPresencaPessoaTurmaDto();
            output.Pessoa = presencaPessoaTurma.Pessoa.Nome + " " + presencaPessoaTurma.Pessoa.Sobrenome;
            output.Presente = presencaPessoaTurma.Presente;
            output.Turma = presencaPessoaTurma.Turma.Nome;
            return output;

        }

        #endregion
        #endregion
    }
}
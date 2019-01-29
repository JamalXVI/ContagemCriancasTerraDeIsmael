using ContagemCriancas.Dto;
using ContagemCriancas.Models;
using ContagemCriancas.Utils;
using System.Collections.Generic;
using System.Linq;

namespace ContagemCriancas.Services.Impl
{
    public class PresencaService : IPresencaService
    {
        //TODO Injetar Serviço de Presença
        private IPresencaPessoaTurmaService presencaPessoaTurmaService;

        public string Salvar(PresencaDto presencaDto)
        {

            Presenca presenca = new Presenca();
            presenca.Data = DataUtils.FormartarNoFormatoPadrao(presencaDto.Data);
            presenca.Presencas = (from presencaPessoaTurmaDto in presencaDto.Presencas select presencaPessoaTurmaService.Salvar(presencaPessoaTurmaDto)).ToList();
            //TODO Salvar no banco de dados
            //TODO Retornar Informação para a view
            return "";
        }

        public List<ResumoPresencas> Resumo(int mes)
        {
            //TODO Retorna o resumo de todas as presenças agrupadas por dia (Fazer no repositório não em lógica)
            List<ResumoPresencas> resumos = null;
            return resumos;
        }

        public List<OutputPresencaDto> RetornarPresencaPorDia(string data)
        {
            //TODO Retornar as presenças filtradas por dia
            List<Presenca> presencas = null;
            List<OutputPresencaDto> presencaDtos = presencas.Converter();
            return presencaDtos;
        }
    }
}
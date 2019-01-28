using ContagemCriancas.Dto;
using System.Collections.Generic;

namespace ContagemCriancas.Services
{
    interface IPresencaService
    {
        string Salvar(PresencaDto presencaDto);
        List<OutputPresencaDto> RetornarPresencaPorDia(string data);
        List<ResumoPresencas> Resumo(int mes);
    }
}

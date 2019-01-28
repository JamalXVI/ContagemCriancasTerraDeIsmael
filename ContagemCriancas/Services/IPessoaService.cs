using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using ContagemCriancas.Enums;
using System.Collections.Generic;

namespace ContagemCriancas.Services
{
    interface IPessoaService
    {
        string Salvar(PessoaDto pessoaDto);
        List<PessoaDto> Listar();
        List<PessoaDto> ListarTipo(TipoPessoa tipoPessoa);
        OutputPessoaDto PesquisarPorId(int IdPessoa);
    }
}

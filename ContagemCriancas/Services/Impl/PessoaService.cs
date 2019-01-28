using ContagemCriancas.Dto;
using ContagemCriancas.Dto.output;
using ContagemCriancas.Enums;
using ContagemCriancas.Models;
using ContagemCriancas.Utils;
using System.Collections.Generic;

namespace ContagemCriancas.Services.Impl
{
    public class PessoaService : IPessoaService
    {

        public string Salvar(PessoaDto pessoaDto)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = pessoaDto.Nome;
            pessoa.Sobrenome = pessoaDto.Sobrenome;
            pessoa.TipoPessoa = (TipoPessoa)pessoaDto.TipoPessoa;
            if (pessoaDto.DataDeNascimento != null)
            {
                pessoa.DataDeNascimento = DataUtils.FormartarNoFormatoPadrao(pessoaDto.DataDeNascimento);
            }
            pessoa.Ativo = true;
            //TODO Salvar no banco de dados
            //TODO Retornar Informação para a view
            return "";
        }
        #region Listagem Geral
        public List<PessoaDto> Listar()
        {
            //TODO Retornar dados salvos do Banco de Dados e ativos
            List<Pessoa> pessoas = null;
            List<PessoaDto> pessoasDto = ConverterUtils.Converter(pessoas);
            return pessoasDto;
        }

        public List<PessoaDto> ListarTipo(TipoPessoa tipoPessoa)
        {
            //TODO Retornar dados salvos do Banco de Dados e ativos, filtrados por tipo de pessoa
            List<Pessoa> pessoas = null;
            List<PessoaDto> pessoasDto = ConverterUtils.Converter(pessoas);
            return pessoasDto;
        }
        #endregion

        public OutputPessoaDto PesquisarPorId(int IdPessoa)
        {
            //TODO Retornar somente do banco de dados aquele Id
            Pessoa pessoa = null;
            OutputPessoaDto pessoaDto = ConverterUtils.Converter(pessoa);
            return pessoaDto;
        }
    }
}
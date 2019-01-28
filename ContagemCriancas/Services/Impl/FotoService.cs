using ContagemCriancas.Dto;
using ContagemCriancas.Models;

namespace ContagemCriancas.Services.Impl
{
    public class FotoService : IFotoService
    {
        public string Salvar(FotoDto fotoDto)
        {
            Foto foto = new Foto();
            //TODO salvar imagem da foto dentro do sistema e guardar referência do arquivo para o banco de dados
            foto.CaminhoFoto = "";
            //TODO buscar pessoa pelo id
            Pessoa pessoa = null;
            foto.Pessoa = pessoa;
            //TODO Salvar no banco de dados
            //TODO Retornar Informação para a view
            return "";

        }
    }
}
namespace ContagemCriancas.Models
{
    //TODO: Relacionar com o Banco de Dados e Fazer Validações
    public class Foto : EntidadeBase
    {
        public Pessoa Pessoa { get; set; }
        public string CaminhoFoto { get; set; }
    }
}
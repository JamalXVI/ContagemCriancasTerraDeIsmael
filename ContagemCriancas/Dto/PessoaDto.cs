namespace ContagemCriancas.Dto
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public string Sobrenome { get; set; }
        /// <summary>
        /// Formato da Data vinda do Front: dd/MM/yyyy
        /// </summary>
        public string DataDeNascimento { get; set; }
        public int TipoPessoa { get; set; }
    }
}
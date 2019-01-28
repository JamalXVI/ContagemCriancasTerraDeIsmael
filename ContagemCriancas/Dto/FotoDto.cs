using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContagemCriancas.Dto
{
    public class FotoDto
    {
        public byte[] Imagem { get; set; }
        public int IdPessoa { get; set; }
    }
}
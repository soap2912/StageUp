using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StageUP.Model.PaginaCadastro
{
    public class CEP_Endereco
    {
        public string Cep {  get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Uf { get; set;}
        public string Cidade { get; set; }

    }
}
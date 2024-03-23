using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StageUP.Model
{
    public class Empresa
    {
        public int Id_Empresa { get; set; }
        public string Cnpj { get; set; }
        public string Ramo { get; set; }
        public string Setor { get; set; }
        public string Nome { get; set; }
    }
}
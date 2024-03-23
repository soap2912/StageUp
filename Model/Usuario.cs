using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StageUP.Model
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Senha { get; set; }   
        public int Ativo { get; set; }
        public int fk_Id_Empresa { get; set; }
        public int fk_Id_Empresa2 { get; set; }
    }
}
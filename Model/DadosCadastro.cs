using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StageUP.Model
{
    public class DadosCadastro
    {
        //classe para setar dados de cadastro
       
       public static Usuario SetarDadosCadastro(string email, string senha) 
        {
            Usuario usuario = new Usuario();
            usuario.Email = email;
            usuario.Senha = senha;
            return usuario;
        }
        
    }
}
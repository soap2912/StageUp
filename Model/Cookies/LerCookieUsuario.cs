using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StageUP.Model.Cookies
{
    public class LerCookieUsuario : System.Web.UI.Page
    {
        public void LerCookie() 
        {
            HttpCookie cookieUsuario = HttpContext.Current.Request.Cookies["CookieUsuario"];
            string json = cookieUsuario.Value;
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            Usuario usuario = new Usuario();
            usuario.Nome = data.nome;
            usuario.Email = data.email;
            usuario.Celular = data.celular;
            usuario.fk_Id_Empresa = data.fk_Id_empresa;
            usuario.Senha = data.senha;
        }

    }
}
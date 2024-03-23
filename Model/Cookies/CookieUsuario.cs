using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace StageUP.Model.Cookies
{
    public class CookieUsuario:System.Web.UI.Page
    {
        public void CriarCookieUsuario(Usuario usuario) 
        {
            // Cria um objeto com múltiplos valores
            var dados = new
            {
                Logado = "ativo",
                nome = usuario.Nome,
                email = usuario.Email,
                celular = usuario.Celular??"",
                senha = usuario.Senha,
                id_empresa = usuario.fk_Id_Empresa.ToString(),
            };
            

            // Serializa o objeto para uma string JSON
            string json = JsonConvert.SerializeObject(dados);

            // Cria um novo cookie
            HttpCookie cookie = new HttpCookie("CookieUsuario");

            // Define o valor do cookie como a string JSON
            cookie.Value = json;
            //Define como um cookie persistente por 10 dias 
            DateTime dataExpiracao = DateTime.Now.AddDays(10);
            cookie.Expires = dataExpiracao;
            // Adiciona o cookie à coleção de cookies da resposta HTTP
            Response.Cookies.Add(cookie);
        }
    }
}
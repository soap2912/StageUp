using StageUP.DAL;
using StageUP.Model;
using StageUP.Model.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StageUP.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["CookieUsuario"] != null)
            {
                LerCookieUsuario lercookies = new LerCookieUsuario();
                //Lê as infos do cookie e joga para a classe usuario
                lercookies.LerCookie();
                //redireciona para proxima pagina
                Response.Redirect("");
            }
        }
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_InputEmail.Text) && !string.IsNullOrWhiteSpace(txt_InputSenha.Text))
            {
                //Verifica se existe um cookie do usuario
                if (Request.Cookies["CookieUsuario"] == null)
                {
                    if (VerificaEmail.ValidarEmail(txt_InputEmail.Text))
                    {
                        Usuario usuario = new Usuario();
                        usuario = DadosCadastro.SetarDadosCadastro(txt_InputEmail.Text, txt_InputSenha.Text);
                        var cadastrado = ConsultaUsuario.ConsultaCadastro(usuario);
                        if (cadastrado == false)
                        {
                            string erro = AlertJS.VerificaErro(cadastrado);
                            AlertJavaScript(erro);
                        }
                        if (cadastrado == true)
                        {
                            CookieUsuario cookieuser = new CookieUsuario();
                            cookieuser.CriarCookieUsuario(usuario);
                            Response.Redirect("");
                        }
                    }
                    else
                    {
                        AlertJavaScript("Formato de email invalido");
                    }
                }
                else if (Request.Cookies["CookieUsuario"] != null)
                {
                    LerCookieUsuario lercookies = new LerCookieUsuario();
                    //Lê as infos do cookie e joga para a classe usuario
                    lercookies.LerCookie();
                    //redireciona para proxima pagina
                    Response.Redirect("");
                }
            }
            else
            {
                var erro = AlertJS.VerificaErro(txt_InputEmail.Text, txt_InputSenha.Text);
                AlertJavaScript(erro);
            }
        }
        protected void AlertJavaScript(string message)
        {
            string script = $@"<script type='text/javascript'>alert('{message}');</script>";

            // Registra o script na página
            ClientScript.RegisterStartupScript(this.GetType(), "alert", script);
        }
      

    }
}
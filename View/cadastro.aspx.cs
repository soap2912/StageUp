using StageUP.DAL;
using StageUP.Model;
using StageUP.Model.API;
using StageUP.Model.PaginaCadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StageUP.View
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt_Nome.EnableViewState = true;
                txt_Sobrenome.EnableViewState = true;
                txt_Email.EnableViewState = true;
                txt_Senha.EnableViewState = true;
                txt_Senha2.EnableViewState = true;
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox> { txt_Nome, txt_Email, txt_Senha, txt_Senha2, txt_Sobrenome, txt_Bairro, txt_Rua, txt_Cidade, txt_CEP };
            if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)))
            {
                if (VerificaEmail.ValidarEmail(txt_Email.Text))
                {

                    if (txt_Senha.Text == txt_Senha2.Text)
                    {
                        AdicionaUsuario.AdicionarUsuario();
                    }
                    else { AlertJavaScript("Senhas não correspondem"); }
                }
                else 
                {
                    AlertJavaScript("Email inválido");
                }
            }
        }
        protected void txt_CEP_TextChanged(object sender, EventArgs e)
        {
            CEP_Endereco cep = new CEP_Endereco();
            cep.Cep = txt_CEP.Text;
            if (cep.Cep.Length == 8)
            {
                ObterEnderecoCorreios obterEndereco = new ObterEnderecoCorreios();
                cep = obterEndereco.PegarEndereco(cep);
                txt_Bairro.Text = cep.Bairro.ToString();
                txt_Cidade.Text = cep.Cidade;
                txt_Rua.Text = cep.Rua;
                drop_Estado.Text = cep.Uf;
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
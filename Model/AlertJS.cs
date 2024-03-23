using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StageUP.Model
{
    public class AlertJS
    {
        public static string VerificaErro(string email, string senha)
        {
            try
            {
                string erro = string.Empty;
                //verifica se usuario não colocou o email
                if (string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha))
                {
                    erro = "Coloque um Email";
                    return erro;
                }
                //verifica se usuario não colocou a senha
                else if (string.IsNullOrEmpty(senha) && !string.IsNullOrEmpty(email))
                {
                    erro = "Coloque uma senha";
                    return erro;
                }
                //verifica se usuario não colocou nem um dos dois 
                else if (string.IsNullOrEmpty(email) && string.IsNullOrEmpty(senha))
                {
                    erro = "Preencha os campos";
                    return erro;
                }
                    return erro;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public static string VerificaErro(bool cadastrado)
        {
            string erro = string.Empty;
            if (!cadastrado)
            {
                erro = "Usuario não encontrado Email/Senha invalidos";
            }
            return erro;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace StageUP.Model
{
    public class VerificaEmail
    {
        public static bool ValidarEmail(string email)
        {
            // Define a expressão regular para validar o formato do email
            string expressaoRegular = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Verifica se o email corresponde à expressão regular
            return Regex.IsMatch(email, expressaoRegular);
        }
    }
}
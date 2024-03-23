using StageUP.Model;
using StageUP.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StageUP.DAL
{
    public class ConsultaUsuario:UsuarioAtivo
    {
        
        // classe criada para verificar se o usuario existe dentro do banco de dados 
        [Obsolete]
        public static bool ConsultaCadastro(Usuario usuario)
        {   
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-33QKTTO;Initial Catalog=STAGEUP;User ID=pablo;Password=12");
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = " SELECT * FROM USUARIO WHERE Email = @EMAIL AND Senha = @SENHA ";
                cmd.Parameters.Add("@EMAIL", usuario.Email);
                cmd.Parameters.Add("@SENHA", usuario.Senha);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    usuario.Nome = reader.GetString(1);
                    usuario.Celular = reader.GetString(3);
                    usuario.Ativo = 1;
                    usuario.fk_Id_Empresa = reader.GetInt32(6);
                    usuario.fk_Id_Empresa2 = reader.GetInt32(7);
                    UsarioOnline(usuario);
                    conn.Close();
                    return true;
                }
                else
                {
                return false;
                }
            }
            catch
            { return false; }

        }
    }
}
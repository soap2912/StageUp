using StageUP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StageUP.DAL
{
    public class UsuarioAtivo
    {
        //classe criada para setar no banco de dados se o usuario está ativo atualmente
       

        [Obsolete]
        public static void UsarioOnline(Usuario usuario)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-33QKTTO;Initial Catalog=STAGEUP;User ID=pablo;Password=12");
            try
            {
                SqlCommand cmd = new SqlCommand()
                {
                    Connection = conn,
                    CommandText = "UPDATE USUARIO" +
                                  "SET ATIVO = @ATIVO"+
                                  "WHERE Id_Usuario = @ID_USUARIO"

                };
                cmd.Parameters.Add("@ATIVO", usuario.Ativo);
                cmd.Parameters.Add("@ID_USUARIO", usuario.Id_Usuario);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch { }
        }
    }
}
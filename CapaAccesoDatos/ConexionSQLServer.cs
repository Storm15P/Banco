using CapaNegocio;
using Microsoft.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class ConexionSQLServer : FuenteDatos
    {
        private SqlConnection conexion;

        public ConexionSQLServer()
        {
            conexion = new SqlConnection(@"TrustServerCertificate=true;Password=Microsoftxbox1!;Persist Security Info=True;User ID=sa;Initial Catalog=Banco;Data Source=LENOVOSW\SQLEXPRESS");
        }

        public RiesgoDTO ConsultarRiesgo(string nroDoc)
        {
            if (int.TryParse(nroDoc, out int documento))
                return ConsultarRiesgo(documento);
            return new RiesgoDTO();
        }

        public RiesgoDTO ConsultarRiesgo(int nroDoc)
        {
            try
            {
                conexion.Open();
                string query = "SELECT TipoDoc, NroDoc, Puntaje FROM usuarios WHERE NroDoc = @NroDoc";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@NroDoc", nroDoc);
                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new RiesgoDTO(
                                reader["TipoDoc"].ToString(),
                                reader["NroDoc"].ToString(),
                                reader["Puntaje"].ToString()
                            );
                        }
                    }
                }
                return new RiesgoDTO();
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
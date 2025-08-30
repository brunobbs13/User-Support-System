using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal static class ConexaoBanco
    {
        public static string connectioSql()
        {
            string ConnectionString = "Server=ATHSRV03;Database=ALCANCE;User Id=sa;Password=Ath@2020!;";
            using (SqlConnection connection = new SqlConnection(ConnectionString)) //É imprtante que toda consulta ao Banco seja iniciada por esse Using, pois ela fechara a conexão automaticamente, não deixando lixos na memoria 
            {
                try
                {
                    connection.Open();
                    //MessageBox.Show("Conexão deu certo");
                    return ConnectionString;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro de conexão: " + ex.Message);
                    return null;
                }
            }
        }
    }
}

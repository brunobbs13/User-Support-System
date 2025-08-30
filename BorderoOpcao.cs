using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class BorderoOpcao
    {
        public int NumeroBordero { get; set; }
        public EstadoBordero Estado { get; set; }
        public BaseDados Base { get; set; }
        public TipoDocumento Tipo { get; set; }
    //Em um textBox buscar um borderô, suas informações, e apresentar dados como "numeroBor, qtd_deTitulos, Valor, tipoBorderô, tipoBoleto, Cedente e etc", e em um ComboBox o usuario selecionar o tipo de borderô desejado. 
    //Se for diferente do atual ele executa um update para o tipo desejado. 

    public void AlteraTipo(SqlConnection conn, BorderoOpcao opcao)
        {
            
            if (opcao.Estado ==  EstadoBordero.Simulado && opcao.Base == BaseDados.ATLANTA && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATLANTA..SBORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Simulado && opcao.Base == BaseDados.ATLAS && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATLAS..SBORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Simulado && opcao.Base == BaseDados.ATHSECUR && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATHSECUR..SBORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATLANTA && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATLANTA..BORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATLAS && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATLAS..BORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATHSECUR && opcao.Tipo == TipoDocumento.FD_DP)
            {
                string sql = "UPDATE ATHSECUR..BORDERO SET BOR_OPEORIGEM = 81 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Simulado && opcao.Base == BaseDados.ATLANTA && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATLANTA..SBORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Simulado && opcao.Base == BaseDados.ATLAS && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATLAS..SBORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Simulado && opcao.Base == BaseDados.ATHSECUR && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATHSECUR..SBORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATLANTA && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATLANTA..BORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATLAS && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATLAS..BORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }
            else if (opcao.Estado == EstadoBordero.Oficializado && opcao.Base == BaseDados.ATHSECUR && opcao.Tipo == TipoDocumento.OE_CF)
            {
                string sql = "UPDATE ATHSECUR..BORDERO SET BOR_OPEORIGEM = 69 WHERE Bor_numero = @Bor_numero";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Bor_numero", opcao.NumeroBordero);
                    cmd.ExecuteNonQuery();
                }
            }


        }
    }
}

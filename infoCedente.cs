using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    internal class infoCedente
    {
        public void SelecaoCedBor(SqlConnection conn, TextBox txtCed, TextBox txtBor, TextBox txtRecebeCed, DataGridView dtInfo)
        {

            try
            {
                conn.Open();

                string vrTxtCed = txtCed.Text;
                string vrTxtBor = txtBor.Text;

                if (string.IsNullOrEmpty(vrTxtCed) && string.IsNullOrEmpty(vrTxtBor))
                {
                    MessageBox.Show("Digite alguma valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!string.IsNullOrEmpty(vrTxtBor) && string.IsNullOrEmpty(vrTxtCed))
                {
                    string queryName = "SELECT Ced_nome FROM ATLANTA..BORDERO INNER JOIN ATLANTA..CEDENTE ON Bor_codced = Ced_ccusto Where Bor_numero = " + vrTxtBor + "";
                    SqlCommand commandCedente = new SqlCommand(queryName, conn);
                    SqlDataReader rdTableCedente = commandCedente.ExecuteReader();

                    while (rdTableCedente.Read())
                    {
                        txtRecebeCed.Text = " - CENDENTE: " + (rdTableCedente[0].ToString()); // Exibe a primeira coluna de cada linha
                    }

                    rdTableCedente.Close();


                    string queryTitulos = "SELECT CONCAT(Tit_Numero,'/',Tit_ordem) as [Borderô],Ced_nome, Tit_Duplic,FORMAT(Tit_Vencto, 'dd/MM/yyyy') as Vencimento,FORMAT(Tit_Valor, 'C', 'pt-br') as Valor, Sac_descus FROM ATLANTA..TITULOS INNER JOIN ATLANTA..CEDENTE ON Tit_CodCed = Ced_ccusto INNER JOIN ATLANTA..SACADO ON Tit_Codsac = Sac_cgc WHERE Tit_Numero =" + vrTxtBor + "";


                    SqlDataAdapter adapterTitulos = new SqlDataAdapter(queryTitulos, conn);
                    DataTable dataTableTitulos = new DataTable();
                    adapterTitulos.Fill(dataTableTitulos);

                    dtInfo.DataSource = dataTableTitulos;
                }
                else if (!string.IsNullOrEmpty(vrTxtCed) && string.IsNullOrEmpty(vrTxtBor))
                {
                    string query = "SELECT  Ced_cgc as CNPJ,FORMAT (Bor_dtoper, 'dd/MM/yyyy') as [Data Operação],Bor_numero as [Borderô],FORMAT (Bor_valor, 'C', 'pt-br') AS Valor FROM ATLANTA..BORDERO INNER JOIN ATLANTA..CEDENTE ON Bor_codced = Ced_ccusto WHERE Ced_cgc =" + vrTxtCed + "";
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        txtRecebeCed.Text = " - CNPJ: " + (reader[0].ToString());
                    }

                    reader.Close();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dtInfo.DataSource = dataTable;
                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show("Error:" + ex.Message);
                }
        }
    }    
}


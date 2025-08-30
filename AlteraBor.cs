using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Teste
{
    public partial class AlteraBor : Form
    {


        public AlteraBor()
        {
            InitializeComponent();
        }

        private BorderoOpcao ObterOpcoesSelecionadas()
        {
            var opcao = new BorderoOpcao();

            // Estado do Borderô
            if (radioButton1.Checked)
                opcao.Estado = EstadoBordero.Simulado;
            else if (radioButton2.Checked)
                opcao.Estado = EstadoBordero.Oficializado;

            // Base
            if (radioButton3.Checked)
                opcao.Base = BaseDados.ATLANTA;
            else if (radioButton4.Checked)
                opcao.Base = BaseDados.ATLAS;
            else if (radioButton5.Checked)
                opcao.Base = BaseDados.ATHSECUR;

            // Tipo
            if (radioButton6.Checked)
                opcao.Tipo = TipoDocumento.FD_DP;
            else if (radioButton7.Checked)
                opcao.Tipo = TipoDocumento.OE_CF;


            // Número do borderô
            if (int.TryParse(textBox1.Text, out int numero))
                opcao.NumeroBordero = numero;
            else
                throw new Exception("Número do borderô inválido.");

            return opcao;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var opcaoSelecionada = ObterOpcoesSelecionadas();

            using (SqlConnection conn = new SqlConnection(ConexaoBanco.connectioSql()))
            {
                conn.Open();
                BorderoOpcao service = new BorderoOpcao();
                service.AlteraTipo(conn, opcaoSelecionada);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}


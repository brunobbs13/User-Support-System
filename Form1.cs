using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Teste
{
    public enum EstadoBordero
    {
        Simulado,
        Oficializado
    }

    public enum BaseDados
    {
        ATLANTA,
        ATLAS,
        ATHSECUR
    }

    public enum TipoDocumento
    {
        FD_DP,
        OE_CF,
        Outro2
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(ConexaoBanco.connectioSql()))//Aqui já esta chamando o proprio metodo, não sendo nescessário chamar esse metodo antes, 
            {
                infoCedente teste = new infoCedente();
                teste.SelecaoCedBor(connection, textBox3, textBox2, textBox1, dataGridView1);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja Sair?",
                                                    "Atenção",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text) || (!String.IsNullOrEmpty(textBox3.Text)))
            {

                textBox2.Clear();
                textBox3.Clear();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                textBox1.Clear();
            }

        }

        private void alterarTipoBorderôToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alterarTipoBorderôToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AlteraBor alterarBor = new AlteraBor();
            //alterarBor.MdiParent = this;
            alterarBor.Show();
        }

        private void borderôToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GerarCSV gerarArquivo = new GerarCSV();
            gerarArquivo.ListTransferCSV(dataGridView1, textBox3, textBox2);
        }

        private void alterarXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlteraXml alteraXml = new AlteraXml();  
            alteraXml.Show();
        }
    }
}

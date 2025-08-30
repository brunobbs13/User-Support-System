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
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Teste
{
    public partial class AlteraXml : Form
    {
        public AlteraXml()
        {
            InitializeComponent();
            button1.Image = Properties.Resources.adArquivo;
            button2.Image = Properties.Resources.correto6711626;
            button5.Image = Properties.Resources.add_77928;

            var cobrStatus = false;
            var emitStatus = false;

            string emitente = null;
            string destinario = null;
            string duplicata = null;
            string parcela = null;
            string vencimento = null;
            string valor = null;


        }
        private List<Duplicata> listaDup;//variavel que vai guardar a lista

        private void AlteraXml_Load(object sender, EventArgs e)
        {
            textInstrucoes.Text =
                                         @"1. Selecione o arquivo para que as informações da nota sejam listadas.

2. Caso queira alterar as informações de Valor e Vencimento, basta selecionar o campo que deseja alterar e digitar o valor desejado.

3. Logo após, para salvar as alterações feitas basta selecionar o botão confirmar.

4. Caso queira adicionar alguma nota, basta selecionar o botão adicionar e completar os dados (Valor e Vencimento).

5. Terminando a alteração das parcelas desejadas, basta salvar o arquivo em um lugar desejado.";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //selecaoArquivo();
            string caminhoXML = selecaoArquivo();
            textBox1.Text = caminhoXML;
            try
            {

                Duplicata dup001 = new Duplicata();
                dup001.CarregaDados(textBox1.Text, textEmit, textDest, textDuplicata, cbxOrdem, textVenctAntigo, textvlAntigo);
                listaDup = dup001.GerarList(caminhoXML, cbxOrdem);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na leitura do xml: " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cbxOrdem.SelectedItem is Duplicata duplicataSelecionada) //Aqui ele vê se o que foi selecionado é um objeto de duplicata (no ComboBox as informações são armazenadas no formato de objetos),
                                                                         //se for ele já cria uma variavel que vai referênciar o item selecionado no objeto sendo assim possível referenciar os outros parâmetros
            {
                // Atualiza os dados com o que o usuário digitou
                duplicataSelecionada.titValor = textvlAntigo.Text;
                duplicataSelecionada.titvenct = textVenctAntigo.Text;

                MessageBox.Show("Alterações salvas na lista!");


            }

        }

        public string selecaoArquivo()
        {
            try
            {
                OpenFileDialog selecaoXml = new OpenFileDialog();

                selecaoXml.InitialDirectory = @""; //alterar diretorio para um que inicialize na area de trabalho do user.
                selecaoXml.Filter = "Arquivos XML (*.xml)|*.xml|Todos os arquivos (*.*)|*.*"; //busca apenas arquivos com extenssão XML
                selecaoXml.FilterIndex = 1; // Define o filtro padrão (1 para XML)
                selecaoXml.RestoreDirectory = true; // Restaura o diretório anterior após fechar a caixa de diálogo

                if (selecaoXml.ShowDialog() == DialogResult.OK)
                {
                    // Obtém o caminho completo do arquivo selecionado e armazena na variável 'caminhoXML'
                    string caminhoXML = selecaoXml.FileName;
                    MessageBox.Show($"Arquivo selecionado: {caminhoXML}", "Caminho do Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return caminhoXML;
                }
                else
                {
                    string caminhoxmlVazio = "Vazio";
                    // Se o usuário cancelou o diálogo (não selecionou nenhum arquivo),
                    // exibe uma mensagem e para a execução do restante do método.
                    MessageBox.Show("Nenhum arquivo XML foi selecionado. Operação cancelada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Sai do método se nenhum arquivo for selecionado
                    return caminhoxmlVazio;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error na seleçaõ do arquivo: " + ex.Message);
                return ex.Message;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog salvarXml = new SaveFileDialog();
                salvarXml.InitialDirectory = @""; //Onde vai salvar
                //salvarXml.DefaultExt = "Arquivos XML (*.xml)|*.xml|Todos os arquivos (*.*)|*.*";
                salvarXml.DefaultExt = "xml";
                salvarXml.FileName = textDuplicata.Text;
                //salvarXml.RestoreDirectory = true;

                if (salvarXml.ShowDialog() == DialogResult.OK) //Aqui ele abre a caixa de Dialogo e já compara o resultado
                {
                    string salvarXML = salvarXml.FileName;
                    string caminhoXML = textBox1.Text;

                    Duplicata dup002 = new Duplicata();
                    //Duplicata.AtualizarXml(caminhoXML, dup002.GerarList(caminhoXML, cbxOrdem), salvarXML); //Não tem nescessidade de instanciar dessa forma.
                    Duplicata.SalvaXml(caminhoXML, listaDup, salvarXML);

                }
                else
                {
                    MessageBox.Show("Nenhum arquivo XML foi selecionado. Operação cancelada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void cbxOrdem_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxOrdem.SelectedItem is Duplicata duplicataSelecionada)
            {
                //cbxOrdem.Text = duplicataSelecionada.OrdemTit;
                textvlAntigo.Text = duplicataSelecionada.titValor.ToString();
                textVenctAntigo.Text = duplicataSelecionada.titvenct.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Duplicata dup002 = new Duplicata();
            dup002.adicionarParcela(listaDup, cbxOrdem);

        }
        
      

    }
}
    


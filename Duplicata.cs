using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Teste
{
    internal class Duplicata
    {
        public string NumTitulo { get; set; }
        public string OrdemTit { get; set; }
        public string titValor { get; set; }
        public string titvenct { get; set; }

        public override string ToString()
        {
               return OrdemTit;
        }

        public List<Duplicata> GerarList(string caminhoXML, ComboBox cbxtOrdem)
        {

            string caminhoXml = caminhoXML; 
            Duplicata infodup = new Duplicata();

            XDocument meuXMLDoc = XDocument.Load(caminhoXml);
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            var infoDup = meuXMLDoc.Descendants(ns + "dup")
                .Select(dup => new Duplicata
                {
                    OrdemTit = (string)dup.Element(ns + "nDup"),
                    titvenct = (string)dup.Element(ns + "dVenc"),
                    titValor = (string)dup.Element(ns + "vDup"),

                }).ToList();

            cbxtOrdem.DataSource = infoDup;
            cbxtOrdem.DisplayMember = "OrdemTit"; // mostra o número

            return infoDup;
        }

        public void CarregaDados(string caminhoXML, TextBox textEmitente, TextBox textDestinario, TextBox textDuplicata, ComboBox cbxtOrdem, TextBox textVenctAntigo, TextBox textvlAntigo) //Populamento inicial dos textBox
        {
            string caminhoXml = caminhoXML; //Corrigir depois
            string emitente = "null";
            string duplicata = null;
            string parcela = null;
            string vencimento = null;
            string valor = null;
            string destinario = "null";

            XmlReader meuXML = XmlReader.Create(caminhoXml); //criando um objeto para ler o arquivo

            Duplicata infodup = new Duplicata();//Colocar dentro do While pra ir criando varias

            while (meuXML.Read())//Lê todo o arquivo sem para, ou seja, passa por todo o arquivo. E dentro desse While vai ser onde ele vai fazer as validações 
            {
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "emit")
                {

                    using (XmlReader subTree = meuXML.ReadSubtree()) // Cria um leitor interno só para essa seção <emit>
                    {
                        while (subTree.Read())
                        {
                            if (subTree.NodeType == XmlNodeType.Element && subTree.Name == "xNome")
                            {
                                emitente = subTree.ReadElementContentAsString();
                                break;
                            }
                        }
                        textEmitente.Text = emitente;
                    }
                }
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "dest")
                {
                    // Criar um leitor interno só para essa seção <emit>
                    using (XmlReader subTree = meuXML.ReadSubtree())
                    {
                        while (subTree.Read())
                        {
                            if (subTree.NodeType == XmlNodeType.Element && subTree.Name == "xNome")
                            {
                                destinario = subTree.ReadElementContentAsString();
                                break;
                            }
                        }
                        textDestinario.Text = destinario;
                    }
                }
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "nFat")
                {
                    infodup.NumTitulo = meuXML.ReadElementContentAsString();
                    textDuplicata.Text = infodup.NumTitulo;
                }
           
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "nFat")
                {
                    duplicata = meuXML.ReadElementContentAsString();
                    textDuplicata.Text = duplicata;
                }


                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "nDup")
                {
                    parcela = meuXML.ReadElementContentAsString();
                    cbxtOrdem.Text = parcela;
                }
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "dVenc")
                {
                    vencimento = meuXML.ReadElementContentAsString();
                    textVenctAntigo.Text = vencimento;
                }
                if (meuXML.NodeType == XmlNodeType.Element && meuXML.Name == "vDup")
                {

                    valor = meuXML.ReadElementContentAsString();
                    textvlAntigo.Text = valor;
                    break;
                }

            }


        }
        public static void SalvaXml(string caminhoXml, List<Duplicata> lista, string caminhoXmlNovo)
        {
            XDocument doc = XDocument.Load(caminhoXml);
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";


            var cobr = doc.Descendants(ns + "cobr").FirstOrDefault();
            if (cobr == null)
            {
                // se não existir <cobr>, cria
                var infNFe = doc.Descendants(ns + "infNFe").FirstOrDefault();
                if (infNFe == null)
                    throw new Exception("Não foi encontrado <infNFe> no XML");

                cobr = new XElement(ns + "cobr");
                infNFe.Add(cobr);
            }

            // Remove duplicatas existentes
            cobr.Elements(ns + "dup").Remove();

            // Adiciona todas da lista novamente
            foreach (var dup in lista)
            {
                var novoDup = new XElement(ns + "dup",
                    new XElement(ns + "nDup", dup.OrdemTit),
                    new XElement(ns + "dVenc", dup.titvenct),
                    new XElement(ns + "vDup", dup.titValor)
                );

                cobr.Add(novoDup);
            }

            // Salva no arquivo
            doc.Save(caminhoXmlNovo);

        }

        public void adicionarParcela(List<Duplicata> lista,  ComboBox cbxtOrdem)
        {
            int slcCombo = cbxtOrdem.Items.Count +1;
            string vlNovoDup;

            if (slcCombo > 9)
            {
                 vlNovoDup = "0" + slcCombo.ToString();
            }
            else
            {
                vlNovoDup = "00" + slcCombo.ToString();
            }

            lista.Add(new Duplicata //estou adicionando como objeto 
            {
                OrdemTit = vlNovoDup,
                titvenct = "0000-00-00",
                titValor = "0.00"
            });

            /*
            foreach (var dup in lista) {
                MessageBox.Show($"{dup.OrdemTit}, {dup.titvenct}, {dup.titValor}");
                MessageBox.Show(""+ slcCombo);
            }
            */

            cbxtOrdem.DataSource = null;
            cbxtOrdem.DataSource = lista;
            cbxtOrdem.DisplayMember = "OrdemTit"; // mostra o número

            MessageBox.Show("Parcela de número " + vlNovoDup + " adicionada!");
        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class GerarCSV
    {
        //Puxar pelo CNPJ
        public string CNPJ {  get; set; }
        public string DtOperacao { get; set; }
        public string Bordero {  get; set; }
        public string Valor { get; set; }


        //Puxar pelo Borderô

        public string BorOrdem { get; set; }

        public string NomeCedente { get; set; }
        public string Titulo { get; set; }
        public string Vencimento { get; set;}
        public string ValorTitulo { get; set;}
        public string NomeSacado { get; set;}


        public void ListTransferCSV (DataGridView DtGrid, TextBox txtCNPJ, TextBox txtBordero) //, TextBox txtCNPJ, TextBox txtBordero
        {
            string caminho = @"C:\Users\bsantana\Desktop\DataGridView\csvRelatorio.csv";

            try
            {
                if (!string.IsNullOrEmpty(txtCNPJ.Text) && string.IsNullOrEmpty(txtBordero.Text))
                {
                    using (StreamWriter csv = new StreamWriter(caminho))
                    {
                        List<GerarCSV> lista = new List<GerarCSV>();
                        csv.WriteLine("CNPJ,DATA DA OPERAÇÃO,BORDERO, VALOR"); //Cabeçalho

                        foreach (DataGridViewRow linhas in DtGrid.Rows)
                        {
                            if (!linhas.IsNewRow)
                            {
                                lista.Add(new GerarCSV
                                {
                                    CNPJ = linhas.Cells["CNPJ"].Value?.ToString(),
                                    DtOperacao = linhas.Cells["Data Operação"].Value?.ToString(),
                                    Bordero = linhas.Cells["Borderô"].Value?.ToString(),
                                    Valor = linhas.Cells["Valor"].Value?.ToString(),
                                });

                            }
                        }
                        foreach (var valores in lista)
                        {
                            csv.WriteLine($"{valores.CNPJ},{valores.DtOperacao},{valores.Bordero},{valores.Valor}");
                        }

                        MessageBox.Show("Arquivo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    }
                }
                else if (string.IsNullOrEmpty(txtCNPJ.Text) && !string.IsNullOrEmpty(txtBordero.Text))
                {
                    using (StreamWriter csv = new StreamWriter(caminho))
                    {
                        List<GerarCSV> lista = new List<GerarCSV>();
                        csv.WriteLine("Bor/Ordem ,Cedente ,Título ,Venciemento , Valor Titulo, Sacado"); //Cabeçalho

                        foreach (DataGridViewRow linhas in DtGrid.Rows)
                        {
                            if (!linhas.IsNewRow)
                            {
                                lista.Add(new GerarCSV
                                {
                                    BorOrdem = linhas.Cells["Borderô"].Value?.ToString(),
                                    NomeCedente = linhas.Cells["ced_nome"].Value?.ToString(),
                                    Titulo = linhas.Cells["tit_duplic"].Value?.ToString(),
                                    Vencimento = linhas.Cells["Vencimento"].Value?.ToString(),
                                    ValorTitulo = linhas.Cells["Valor"].Value?.ToString(),
                                    NomeSacado = linhas.Cells["sac_descus"].Value?.ToString(),
                                });

                            }
                        }
                        // MessageBox.Show($"{NomeCedente},{Titulo},{Vencimento},{ValorTitulo},{NomeSacado}");

                        foreach (var valores in lista)
                        {
                            csv.WriteLine($"{valores.BorOrdem},{valores.NomeCedente},{valores.Titulo},{valores.Vencimento},{valores.ValorTitulo},{valores.NomeSacado}");
                        }

                        MessageBox.Show("Arquivo gerado com sucesso!", "Sucesso", MessageBoxButtons.OK);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
                //Selecionar com o If, e Try Cath
            }
        }
    }


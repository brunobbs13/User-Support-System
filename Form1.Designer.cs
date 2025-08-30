namespace Teste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            borderôToolStripMenuItem = new ToolStripMenuItem();
            alterarTipoBorderôToolStripMenuItem = new ToolStripMenuItem();
            alterarTipoBoletoToolStripMenuItem = new ToolStripMenuItem();
            arquivosToolStripMenuItem = new ToolStripMenuItem();
            alterarXMLToolStripMenuItem = new ToolStripMenuItem();
            button4 = new Button();
            borderôToolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 177);
            button1.Name = "button1";
            button1.Size = new Size(111, 28);
            button1.TabIndex = 0;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(458, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(255, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(573, 315);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 61);
            textBox3.MaxLength = 14;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(237, 315);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(62, 245);
            button3.Name = "button3";
            button3.Size = new Size(111, 27);
            button3.TabIndex = 8;
            button3.Text = "Fechar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(62, 211);
            button2.Name = "button2";
            button2.Size = new Size(111, 28);
            button2.TabIndex = 7;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 107);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Borderô";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 5;
            label1.Text = "CNPJ Cedente:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { borderôToolStripMenuItem, arquivosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(840, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // borderôToolStripMenuItem
            // 
            borderôToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarTipoBorderôToolStripMenuItem, alterarTipoBoletoToolStripMenuItem, borderôToolStripMenuItem1 });
            borderôToolStripMenuItem.Name = "borderôToolStripMenuItem";
            borderôToolStripMenuItem.Size = new Size(61, 20);
            borderôToolStripMenuItem.Text = "Borderô";
            borderôToolStripMenuItem.Click += borderôToolStripMenuItem_Click;
            // 
            // alterarTipoBorderôToolStripMenuItem
            // 
            alterarTipoBorderôToolStripMenuItem.Name = "alterarTipoBorderôToolStripMenuItem";
            alterarTipoBorderôToolStripMenuItem.Size = new Size(181, 22);
            alterarTipoBorderôToolStripMenuItem.Text = "Alterar Tipo Borderô";
            alterarTipoBorderôToolStripMenuItem.Click += alterarTipoBorderôToolStripMenuItem_Click_1;
            // 
            // alterarTipoBoletoToolStripMenuItem
            // 
            alterarTipoBoletoToolStripMenuItem.Name = "alterarTipoBoletoToolStripMenuItem";
            alterarTipoBoletoToolStripMenuItem.Size = new Size(181, 22);
            alterarTipoBoletoToolStripMenuItem.Text = "Alterar Tipo Boleto";
            // 
            // arquivosToolStripMenuItem
            // 
            arquivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alterarXMLToolStripMenuItem });
            arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            arquivosToolStripMenuItem.Size = new Size(66, 20);
            arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // alterarXMLToolStripMenuItem
            // 
            alterarXMLToolStripMenuItem.Name = "alterarXMLToolStripMenuItem";
            alterarXMLToolStripMenuItem.Size = new Size(136, 22);
            alterarXMLToolStripMenuItem.Text = "Alterar XML";
            alterarXMLToolStripMenuItem.Click += alterarXMLToolStripMenuItem_Click;
            // 
            // button4
            // 
            button4.Location = new Point(723, 391);
            button4.Name = "button4";
            button4.Size = new Size(105, 35);
            button4.TabIndex = 8;
            button4.Text = "Exportar CSV";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // borderôToolStripMenuItem1
            // 
            borderôToolStripMenuItem1.Name = "borderôToolStripMenuItem1";
            borderôToolStripMenuItem1.Size = new Size(181, 22);
            borderôToolStripMenuItem1.Text = "Borderô";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 438);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem borderôToolStripMenuItem;
        private ToolStripMenuItem alterarTipoBorderôToolStripMenuItem;
        private ToolStripMenuItem alterarTipoBoletoToolStripMenuItem;
        private Button button4;
        private ToolStripMenuItem arquivosToolStripMenuItem;
        private ToolStripMenuItem alterarXMLToolStripMenuItem;
        private ToolStripMenuItem borderôToolStripMenuItem1;
    }
}

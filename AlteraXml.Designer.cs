namespace Teste
{
    partial class AlteraXml
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button5 = new Button();
            cbxOrdem = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            textDest = new TextBox();
            textEmit = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textVenctAntigo = new TextBox();
            textvlAntigo = new TextBox();
            textDuplicata = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textInstrucoes = new TextBox();
            button4 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.DialogResult = DialogResult.Yes;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(6, 31);
            button1.Name = "button1";
            button1.Size = new Size(57, 53);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(128, 17);
            label1.TabIndex = 1;
            label1.Text = "Selecione o Arquivo";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(69, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 100);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(cbxOrdem);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textDest);
            groupBox2.Controls.Add(textEmit);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textVenctAntigo);
            groupBox2.Controls.Add(textvlAntigo);
            groupBox2.Controls.Add(textDuplicata);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 259);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Location = new Point(330, 174);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 18;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // cbxOrdem
            // 
            cbxOrdem.FormattingEnabled = true;
            cbxOrdem.Location = new Point(252, 112);
            cbxOrdem.Name = "cbxOrdem";
            cbxOrdem.Size = new Size(57, 23);
            cbxOrdem.TabIndex = 17;
            cbxOrdem.SelectedIndexChanged += cbxOrdem_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 55);
            label8.Name = "label8";
            label8.Size = new Size(95, 14);
            label8.TabIndex = 15;
            label8.Text = "destinatario:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 26);
            label7.Name = "label7";
            label7.Size = new Size(68, 14);
            label7.TabIndex = 14;
            label7.Text = "Emitente:";
            // 
            // textDest
            // 
            textDest.Enabled = false;
            textDest.Location = new Point(103, 51);
            textDest.Name = "textDest";
            textDest.Size = new Size(398, 23);
            textDest.TabIndex = 13;
            // 
            // textEmit
            // 
            textEmit.Enabled = false;
            textEmit.Location = new Point(103, 22);
            textEmit.Name = "textEmit";
            textEmit.Size = new Size(398, 23);
            textEmit.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 181);
            label4.Name = "label4";
            label4.Size = new Size(80, 14);
            label4.TabIndex = 9;
            label4.Text = "Vencimento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 140);
            label3.Name = "label3";
            label3.Size = new Size(43, 14);
            label3.TabIndex = 8;
            label3.Text = "Valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(177, 95);
            label2.Name = "label2";
            label2.Size = new Size(120, 14);
            label2.TabIndex = 7;
            label2.Text = "Duplicata / Ordem";
            // 
            // textVenctAntigo
            // 
            textVenctAntigo.Location = new Point(186, 196);
            textVenctAntigo.Name = "textVenctAntigo";
            textVenctAntigo.Size = new Size(100, 23);
            textVenctAntigo.TabIndex = 4;
            // 
            // textvlAntigo
            // 
            textvlAntigo.Location = new Point(186, 155);
            textvlAntigo.Name = "textvlAntigo";
            textvlAntigo.Size = new Size(100, 23);
            textvlAntigo.TabIndex = 3;
            // 
            // textDuplicata
            // 
            textDuplicata.Enabled = false;
            textDuplicata.Location = new Point(167, 112);
            textDuplicata.Name = "textDuplicata";
            textDuplicata.Size = new Size(79, 23);
            textDuplicata.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.CausesValidation = false;
            button2.Location = new Point(330, 132);
            button2.Name = "button2";
            button2.Size = new Size(30, 29);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(578, 314);
            button3.Name = "button3";
            button3.Size = new Size(109, 45);
            button3.TabIndex = 16;
            button3.Text = "Salvar Arquivo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textInstrucoes
            // 
            textInstrucoes.BackColor = SystemColors.ScrollBar;
            textInstrucoes.Location = new Point(14, 20);
            textInstrucoes.Multiline = true;
            textInstrucoes.Name = "textInstrucoes";
            textInstrucoes.Size = new Size(273, 247);
            textInstrucoes.TabIndex = 5;
            // 
            // button4
            // 
            button4.Location = new Point(730, 314);
            button4.Name = "button4";
            button4.Size = new Size(107, 45);
            button4.TabIndex = 17;
            button4.Text = "Fechar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textInstrucoes);
            groupBox3.Location = new Point(550, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(307, 284);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "INSTRUÇÕES";
            // 
            // AlteraXml
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(869, 381);
            Controls.Add(groupBox3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AlteraXml";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlteraXml";
            Load += AlteraXml_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textVenctAntigo;
        private TextBox textvlAntigo;
        private TextBox textDuplicata;
        private Button button2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textDest;
        private TextBox textEmit;
        private Label label8;
        private Label label7;
        private Button button3;
        private ComboBox cbxOrdem;
        private TextBox textInstrucoes;
        private Button button4;
        private GroupBox groupBox3;
        private Button button5;
    }
}
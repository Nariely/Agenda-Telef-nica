namespace Agenda_Telefonica
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn1 = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.txb2 = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txb3 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblVeja = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 416);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage1.Controls.Add(this.lblErro);
            this.tabPage1.Controls.Add(this.txb2);
            this.tabPage1.Controls.Add(this.txb1);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Controls.Add(this.btn1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Adicionar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage2.Controls.Add(this.lblVeja);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.btn3);
            this.tabPage2.Controls.Add(this.txb3);
            this.tabPage2.Controls.Add(this.lblPesquisar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualizar";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.PaleGreen;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Location = new System.Drawing.Point(306, 216);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Gravar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(195, 143);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Insira seu Nome";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(375, 143);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(92, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Insira seu Contato";
            // 
            // txb1
            // 
            this.txb1.Location = new System.Drawing.Point(198, 159);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 20);
            this.txb1.TabIndex = 3;
            // 
            // txb2
            // 
            this.txb2.Location = new System.Drawing.Point(378, 159);
            this.txb2.Name = "txb2";
            this.txb2.Size = new System.Drawing.Size(100, 20);
            this.txb2.TabIndex = 4;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(21, 39);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(127, 13);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Pesquisar na sua agenda";
            // 
            // txb3
            // 
            this.txb3.Location = new System.Drawing.Point(24, 69);
            this.txb3.Name = "txb3";
            this.txb3.Size = new System.Drawing.Size(100, 20);
            this.txb3.TabIndex = 1;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.PaleGreen;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Location = new System.Drawing.Point(24, 109);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Buscar";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(185, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(455, 294);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // lblVeja
            // 
            this.lblVeja.AutoSize = true;
            this.lblVeja.Location = new System.Drawing.Point(182, 53);
            this.lblVeja.Name = "lblVeja";
            this.lblVeja.Size = new System.Drawing.Size(97, 13);
            this.lblVeja.TabIndex = 4;
            this.lblVeja.Text = "Veja mais Detalhes";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(59, 344);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(41, 13);
            this.lblErro.TabIndex = 5;
            this.lblErro.Text = "<Error>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txb2;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblVeja;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox txb3;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblErro;
    }
}


namespace PadraoNumerosSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtNumerosEntrada = new System.Windows.Forms.TextBox();
            this.TxtNumeroSaida = new System.Windows.Forms.TextBox();
            this.BtnPadronizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelTotalNumerosCorrigidos = new System.Windows.Forms.Label();
            this.TxtMensagemEntrada = new System.Windows.Forms.TextBox();
            this.TxtMensagemSaida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparNumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparMensagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNumerosEntrada
            // 
            this.TxtNumerosEntrada.Location = new System.Drawing.Point(12, 40);
            this.TxtNumerosEntrada.Multiline = true;
            this.TxtNumerosEntrada.Name = "TxtNumerosEntrada";
            this.TxtNumerosEntrada.Size = new System.Drawing.Size(298, 186);
            this.TxtNumerosEntrada.TabIndex = 0;
            this.TxtNumerosEntrada.WordWrap = false;
            // 
            // TxtNumeroSaida
            // 
            this.TxtNumeroSaida.Location = new System.Drawing.Point(325, 40);
            this.TxtNumeroSaida.Multiline = true;
            this.TxtNumeroSaida.Name = "TxtNumeroSaida";
            this.TxtNumeroSaida.ReadOnly = true;
            this.TxtNumeroSaida.Size = new System.Drawing.Size(298, 186);
            this.TxtNumeroSaida.TabIndex = 1;
            // 
            // BtnPadronizar
            // 
            this.BtnPadronizar.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPadronizar.Location = new System.Drawing.Point(144, 404);
            this.BtnPadronizar.Name = "BtnPadronizar";
            this.BtnPadronizar.Size = new System.Drawing.Size(109, 58);
            this.BtnPadronizar.TabIndex = 2;
            this.BtnPadronizar.Text = "Padronizar";
            this.BtnPadronizar.UseVisualStyleBackColor = true;
            this.BtnPadronizar.Click += new System.EventHandler(this.PadronizaNumerosEMensagem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numeros para serem corrigidos.:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numeros corrigidos.:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "Copiar\r\nNumero";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CopiaConteudoCorrigido);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total de numeros corrigidos.:";
            // 
            // LabelTotalNumerosCorrigidos
            // 
            this.LabelTotalNumerosCorrigidos.AutoSize = true;
            this.LabelTotalNumerosCorrigidos.Location = new System.Drawing.Point(471, 229);
            this.LabelTotalNumerosCorrigidos.Name = "LabelTotalNumerosCorrigidos";
            this.LabelTotalNumerosCorrigidos.Size = new System.Drawing.Size(0, 13);
            this.LabelTotalNumerosCorrigidos.TabIndex = 7;
            // 
            // TxtMensagemEntrada
            // 
            this.TxtMensagemEntrada.Location = new System.Drawing.Point(12, 270);
            this.TxtMensagemEntrada.Multiline = true;
            this.TxtMensagemEntrada.Name = "TxtMensagemEntrada";
            this.TxtMensagemEntrada.Size = new System.Drawing.Size(298, 128);
            this.TxtMensagemEntrada.TabIndex = 8;
            // 
            // TxtMensagemSaida
            // 
            this.TxtMensagemSaida.Location = new System.Drawing.Point(325, 270);
            this.TxtMensagemSaida.Multiline = true;
            this.TxtMensagemSaida.Name = "TxtMensagemSaida";
            this.TxtMensagemSaida.ReadOnly = true;
            this.TxtMensagemSaida.Size = new System.Drawing.Size(298, 128);
            this.TxtMensagemSaida.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mensagem a ser enviada.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mensagem corrigida.:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 58);
            this.button2.TabIndex = 12;
            this.button2.Text = "Copiar\r\nMensagem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CopiaMensagemPadronizada);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparNumerosToolStripMenuItem,
            this.limparMensagemToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // limparNumerosToolStripMenuItem
            // 
            this.limparNumerosToolStripMenuItem.Name = "limparNumerosToolStripMenuItem";
            this.limparNumerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparNumerosToolStripMenuItem.Text = "Limpar Numeros";
            this.limparNumerosToolStripMenuItem.Click += new System.EventHandler(this.limparNumerosToolStripMenuItem_Click);
            // 
            // limparMensagemToolStripMenuItem
            // 
            this.limparMensagemToolStripMenuItem.Name = "limparMensagemToolStripMenuItem";
            this.limparMensagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparMensagemToolStripMenuItem.Text = "Limpar mensagem";
            this.limparMensagemToolStripMenuItem.Click += new System.EventHandler(this.limparMensagemToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtMensagemSaida);
            this.Controls.Add(this.TxtMensagemEntrada);
            this.Controls.Add(this.LabelTotalNumerosCorrigidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPadronizar);
            this.Controls.Add(this.TxtNumeroSaida);
            this.Controls.Add(this.TxtNumerosEntrada);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padronizador de mensagens ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNumerosEntrada;
        private System.Windows.Forms.TextBox TxtNumeroSaida;
        private System.Windows.Forms.Button BtnPadronizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelTotalNumerosCorrigidos;
        private System.Windows.Forms.TextBox TxtMensagemEntrada;
        private System.Windows.Forms.TextBox TxtMensagemSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparNumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparMensagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
    }
}


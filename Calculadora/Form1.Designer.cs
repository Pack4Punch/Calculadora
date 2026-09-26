namespace Calculadora
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
            btnVirgula = new Button();
            btnSete = new Button();
            btnOito = new Button();
            btnNove = new Button();
            btnQuatro = new Button();
            btnCinco = new Button();
            btnSeis = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnZero = new Button();
            btnRetroceder = new Button();
            btnAdicao = new Button();
            btnSubtracao = new Button();
            btnMultiplicacao = new Button();
            btnDivisao = new Button();
            btnCe = new Button();
            btnC = new Button();
            btnIgual = new Button();
            txtResultado = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(12, 138);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(41, 23);
            btnVirgula.TabIndex = 0;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(12, 109);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(41, 23);
            btnSete.TabIndex = 1;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(59, 109);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(37, 23);
            btnOito.TabIndex = 2;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(102, 109);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(40, 23);
            btnNove.TabIndex = 3;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(12, 80);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(41, 23);
            btnQuatro.TabIndex = 4;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(59, 80);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(37, 23);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(102, 80);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(40, 23);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(12, 51);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(41, 23);
            btnUm.TabIndex = 7;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(59, 51);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(37, 23);
            btnDois.TabIndex = 8;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(102, 51);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(40, 23);
            btnTres.TabIndex = 9;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(59, 138);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(37, 23);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnRetroceder
            // 
            btnRetroceder.Location = new Point(102, 138);
            btnRetroceder.Name = "btnRetroceder";
            btnRetroceder.Size = new Size(40, 23);
            btnRetroceder.TabIndex = 11;
            btnRetroceder.Text = "<";
            btnRetroceder.UseVisualStyleBackColor = true;
            // 
            // btnAdicao
            // 
            btnAdicao.Location = new Point(148, 138);
            btnAdicao.Name = "btnAdicao";
            btnAdicao.Size = new Size(41, 23);
            btnAdicao.TabIndex = 12;
            btnAdicao.Text = "+";
            btnAdicao.UseVisualStyleBackColor = true;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Location = new Point(148, 109);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(41, 23);
            btnSubtracao.TabIndex = 13;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Location = new Point(148, 80);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(41, 23);
            btnMultiplicacao.TabIndex = 14;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // btnDivisao
            // 
            btnDivisao.Location = new Point(148, 51);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(41, 23);
            btnDivisao.TabIndex = 15;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            // 
            // btnCe
            // 
            btnCe.Location = new Point(195, 51);
            btnCe.Name = "btnCe";
            btnCe.Size = new Size(43, 23);
            btnCe.TabIndex = 16;
            btnCe.Text = "CE";
            btnCe.UseVisualStyleBackColor = true;
            // 
            // btnC
            // 
            btnC.Location = new Point(195, 80);
            btnC.Name = "btnC";
            btnC.Size = new Size(43, 23);
            btnC.TabIndex = 17;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(195, 109);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(43, 52);
            btnIgual.TabIndex = 18;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 12);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(226, 23);
            txtResultado.TabIndex = 19;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += txtResultado_TextChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(17, 16);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 177);
            Controls.Add(lblResultado);
            Controls.Add(txtResultado);
            Controls.Add(btnIgual);
            Controls.Add(btnC);
            Controls.Add(btnCe);
            Controls.Add(btnDivisao);
            Controls.Add(btnMultiplicacao);
            Controls.Add(btnSubtracao);
            Controls.Add(btnAdicao);
            Controls.Add(btnRetroceder);
            Controls.Add(btnZero);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnVirgula);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVirgula;
        private Button btnSete;
        private Button btnOito;
        private Button btnNove;
        private Button btnQuatro;
        private Button btnCinco;
        private Button btnSeis;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnZero;
        private Button btnRetroceder;
        private Button btnAdicao;
        private Button btnSubtracao;
        private Button btnMultiplicacao;
        private Button btnDivisao;
        private Button btnCe;
        private Button btnC;
        private Button btnIgual;
        private TextBox txtResultado;
        private Label lblResultado;
    }
}

namespace Flashcards
{
    partial class formTelaDeRevisao
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
            this.txtPerguntaTelaDeRevisao = new System.Windows.Forms.TextBox();
            this.rtxtRespostaTelaDeRevisao = new System.Windows.Forms.RichTextBox();
            this.btnRespotaTelaDeRevisao = new System.Windows.Forms.Button();
            this.btnCertoTelaDeRevisao = new System.Windows.Forms.Button();
            this.btnRasoavelTelaDeRevisao = new System.Windows.Forms.Button();
            this.btnPararTelaDeRevisao = new System.Windows.Forms.Button();
            this.btnErradoTelaDeRevisao = new System.Windows.Forms.Button();
            this.txtContadorCardsTelaDeRevisao = new System.Windows.Forms.TextBox();
            this.btnPausarTelaDeRevisao = new System.Windows.Forms.Button();
            this.lblDisciplinaTelaDeRevisao = new System.Windows.Forms.Label();
            this.lblBaralhoTelaDeRevisao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPerguntaTelaDeRevisao
            // 
            this.txtPerguntaTelaDeRevisao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPerguntaTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPerguntaTelaDeRevisao.Location = new System.Drawing.Point(60, 61);
            this.txtPerguntaTelaDeRevisao.Name = "txtPerguntaTelaDeRevisao";
            this.txtPerguntaTelaDeRevisao.Size = new System.Drawing.Size(413, 22);
            this.txtPerguntaTelaDeRevisao.TabIndex = 0;
            this.txtPerguntaTelaDeRevisao.Text = "Qual a capital do Brasil?";
            this.txtPerguntaTelaDeRevisao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtxtRespostaTelaDeRevisao
            // 
            this.rtxtRespostaTelaDeRevisao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtxtRespostaTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtRespostaTelaDeRevisao.Location = new System.Drawing.Point(60, 101);
            this.rtxtRespostaTelaDeRevisao.Name = "rtxtRespostaTelaDeRevisao";
            this.rtxtRespostaTelaDeRevisao.Size = new System.Drawing.Size(413, 63);
            this.rtxtRespostaTelaDeRevisao.TabIndex = 1;
            this.rtxtRespostaTelaDeRevisao.Text = "Brasília";
            // 
            // btnRespotaTelaDeRevisao
            // 
            this.btnRespotaTelaDeRevisao.Location = new System.Drawing.Point(60, 189);
            this.btnRespotaTelaDeRevisao.Name = "btnRespotaTelaDeRevisao";
            this.btnRespotaTelaDeRevisao.Size = new System.Drawing.Size(70, 23);
            this.btnRespotaTelaDeRevisao.TabIndex = 2;
            this.btnRespotaTelaDeRevisao.Text = "Resposta";
            this.btnRespotaTelaDeRevisao.UseVisualStyleBackColor = true;
            this.btnRespotaTelaDeRevisao.Click += new System.EventHandler(this.btnRespotaTelaDeRevisao_Click);
            // 
            // btnCertoTelaDeRevisao
            // 
            this.btnCertoTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCertoTelaDeRevisao.Location = new System.Drawing.Point(213, 189);
            this.btnCertoTelaDeRevisao.Name = "btnCertoTelaDeRevisao";
            this.btnCertoTelaDeRevisao.Size = new System.Drawing.Size(30, 23);
            this.btnCertoTelaDeRevisao.TabIndex = 3;
            this.btnCertoTelaDeRevisao.Text = "2";
            this.btnCertoTelaDeRevisao.UseVisualStyleBackColor = true;
            // 
            // btnRasoavelTelaDeRevisao
            // 
            this.btnRasoavelTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRasoavelTelaDeRevisao.Location = new System.Drawing.Point(249, 189);
            this.btnRasoavelTelaDeRevisao.Name = "btnRasoavelTelaDeRevisao";
            this.btnRasoavelTelaDeRevisao.Size = new System.Drawing.Size(30, 23);
            this.btnRasoavelTelaDeRevisao.TabIndex = 4;
            this.btnRasoavelTelaDeRevisao.Text = "0";
            this.btnRasoavelTelaDeRevisao.UseVisualStyleBackColor = true;
            // 
            // btnPararTelaDeRevisao
            // 
            this.btnPararTelaDeRevisao.Location = new System.Drawing.Point(403, 189);
            this.btnPararTelaDeRevisao.Name = "btnPararTelaDeRevisao";
            this.btnPararTelaDeRevisao.Size = new System.Drawing.Size(70, 23);
            this.btnPararTelaDeRevisao.TabIndex = 5;
            this.btnPararTelaDeRevisao.Text = "Parar";
            this.btnPararTelaDeRevisao.UseVisualStyleBackColor = true;
            // 
            // btnErradoTelaDeRevisao
            // 
            this.btnErradoTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnErradoTelaDeRevisao.Location = new System.Drawing.Point(285, 189);
            this.btnErradoTelaDeRevisao.Name = "btnErradoTelaDeRevisao";
            this.btnErradoTelaDeRevisao.Size = new System.Drawing.Size(30, 23);
            this.btnErradoTelaDeRevisao.TabIndex = 6;
            this.btnErradoTelaDeRevisao.Text = "1";
            this.btnErradoTelaDeRevisao.UseVisualStyleBackColor = true;
            // 
            // txtContadorCardsTelaDeRevisao
            // 
            this.txtContadorCardsTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtContadorCardsTelaDeRevisao.Location = new System.Drawing.Point(136, 189);
            this.txtContadorCardsTelaDeRevisao.Name = "txtContadorCardsTelaDeRevisao";
            this.txtContadorCardsTelaDeRevisao.Size = new System.Drawing.Size(60, 23);
            this.txtContadorCardsTelaDeRevisao.TabIndex = 7;
            this.txtContadorCardsTelaDeRevisao.Text = "3/20";
            this.txtContadorCardsTelaDeRevisao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPausarTelaDeRevisao
            // 
            this.btnPausarTelaDeRevisao.Location = new System.Drawing.Point(327, 189);
            this.btnPausarTelaDeRevisao.Name = "btnPausarTelaDeRevisao";
            this.btnPausarTelaDeRevisao.Size = new System.Drawing.Size(70, 23);
            this.btnPausarTelaDeRevisao.TabIndex = 8;
            this.btnPausarTelaDeRevisao.Text = "Pausar";
            this.btnPausarTelaDeRevisao.UseVisualStyleBackColor = true;
            // 
            // lblDisciplinaTelaDeRevisao
            // 
            this.lblDisciplinaTelaDeRevisao.AutoSize = true;
            this.lblDisciplinaTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisciplinaTelaDeRevisao.Location = new System.Drawing.Point(60, 9);
            this.lblDisciplinaTelaDeRevisao.Name = "lblDisciplinaTelaDeRevisao";
            this.lblDisciplinaTelaDeRevisao.Size = new System.Drawing.Size(62, 15);
            this.lblDisciplinaTelaDeRevisao.TabIndex = 9;
            this.lblDisciplinaTelaDeRevisao.Text = "Geografia";
            // 
            // lblBaralhoTelaDeRevisao
            // 
            this.lblBaralhoTelaDeRevisao.AutoSize = true;
            this.lblBaralhoTelaDeRevisao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaralhoTelaDeRevisao.Location = new System.Drawing.Point(136, 9);
            this.lblBaralhoTelaDeRevisao.Name = "lblBaralhoTelaDeRevisao";
            this.lblBaralhoTelaDeRevisao.Size = new System.Drawing.Size(56, 15);
            this.lblBaralhoTelaDeRevisao.TabIndex = 10;
            this.lblBaralhoTelaDeRevisao.Text = "Baralho1";
            // 
            // formTelaDeRevisao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(524, 289);
            this.Controls.Add(this.lblBaralhoTelaDeRevisao);
            this.Controls.Add(this.lblDisciplinaTelaDeRevisao);
            this.Controls.Add(this.btnPausarTelaDeRevisao);
            this.Controls.Add(this.txtContadorCardsTelaDeRevisao);
            this.Controls.Add(this.btnErradoTelaDeRevisao);
            this.Controls.Add(this.btnPararTelaDeRevisao);
            this.Controls.Add(this.btnRasoavelTelaDeRevisao);
            this.Controls.Add(this.btnCertoTelaDeRevisao);
            this.Controls.Add(this.btnRespotaTelaDeRevisao);
            this.Controls.Add(this.rtxtRespostaTelaDeRevisao);
            this.Controls.Add(this.txtPerguntaTelaDeRevisao);
            this.Name = "formTelaDeRevisao";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formTelaDeRevisao_FormClosed);
            this.Load += new System.EventHandler(this.formTelaDeRevisao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPerguntaTelaDeRevisao;
        private RichTextBox rtxtRespostaTelaDeRevisao;
        private Button btnRespotaTelaDeRevisao;
        private Button btnCertoTelaDeRevisao;
        private Button btnRasoavelTelaDeRevisao;
        private Button btnPararTelaDeRevisao;
        private Button btnErradoTelaDeRevisao;
        private TextBox txtContadorCardsTelaDeRevisao;
        private Button btnPausarTelaDeRevisao;
        private Label lblDisciplinaTelaDeRevisao;
        private Label lblBaralhoTelaDeRevisao;
    }
}
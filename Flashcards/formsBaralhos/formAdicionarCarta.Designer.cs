namespace Flashcards.formsBaralhos
{
    partial class formAdicionarCarta
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
            this.lblNomeDisciplina = new System.Windows.Forms.Label();
            this.lblPergunta = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeDisciplina
            // 
            this.lblNomeDisciplina.AutoSize = true;
            this.lblNomeDisciplina.Location = new System.Drawing.Point(60, 28);
            this.lblNomeDisciplina.Name = "lblNomeDisciplina";
            this.lblNomeDisciplina.Size = new System.Drawing.Size(58, 15);
            this.lblNomeDisciplina.TabIndex = 0;
            this.lblNomeDisciplina.Text = "Disciplina";
            // 
            // lblPergunta
            // 
            this.lblPergunta.AutoSize = true;
            this.lblPergunta.Location = new System.Drawing.Point(60, 104);
            this.lblPergunta.Name = "lblPergunta";
            this.lblPergunta.Size = new System.Drawing.Size(98, 15);
            this.lblPergunta.TabIndex = 1;
            this.lblPergunta.Text = "Insira a pergunta:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(60, 167);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(54, 15);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(381, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(381, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 185);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(381, 23);
            this.textBox3.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(120, 291);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Confirmar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(277, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // formAdicionarCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(146)))), ((int)(((byte)(158)))));
            this.ClientSize = new System.Drawing.Size(580, 373);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblPergunta);
            this.Controls.Add(this.lblNomeDisciplina);
            this.Name = "formAdicionarCarta";
            this.Text = "formAdicionarCarta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeDisciplina;
        private Label lblPergunta;
        private Label lblResposta;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnOk;
        private Button btnCancel;
    }
}
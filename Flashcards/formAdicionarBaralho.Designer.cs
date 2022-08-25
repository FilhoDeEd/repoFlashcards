namespace Flashcards
{
    partial class formAdicionarBaralho
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
            this.lblCriarBaralho = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnCancelarCriarBaralho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCriarBaralho
            // 
            this.lblCriarBaralho.AutoSize = true;
            this.lblCriarBaralho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCriarBaralho.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCriarBaralho.Location = new System.Drawing.Point(161, 24);
            this.lblCriarBaralho.Name = "lblCriarBaralho";
            this.lblCriarBaralho.Size = new System.Drawing.Size(202, 15);
            this.lblCriarBaralho.TabIndex = 0;
            this.lblCriarBaralho.Text = "Insira o nome do novo baralho:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.textBox1.Location = new System.Drawing.Point(90, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 23);
            this.textBox1.TabIndex = 1;
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Location = new System.Drawing.Point(164, 122);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(90, 23);
            this.btnCriar.TabIndex = 2;
            this.btnCriar.Text = "Criar Baralho";
            this.btnCriar.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCriarBaralho
            // 
            this.btnCancelarCriarBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnCancelarCriarBaralho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCriarBaralho.Location = new System.Drawing.Point(277, 122);
            this.btnCancelarCriarBaralho.Name = "btnCancelarCriarBaralho";
            this.btnCancelarCriarBaralho.Size = new System.Drawing.Size(90, 23);
            this.btnCancelarCriarBaralho.TabIndex = 3;
            this.btnCancelarCriarBaralho.Text = "Cancelar";
            this.btnCancelarCriarBaralho.UseVisualStyleBackColor = false;
            // 
            // formAdicionarBaralho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(539, 157);
            this.Controls.Add(this.btnCancelarCriarBaralho);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCriarBaralho);
            this.Name = "formAdicionarBaralho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar baralho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCriarBaralho;
        private TextBox textBox1;
        private Button btnCriar;
        private Button btnCancelarCriarBaralho;
    }
}
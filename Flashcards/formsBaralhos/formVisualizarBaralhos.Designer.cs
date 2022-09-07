namespace Flashcards
{
    partial class formVisualizarBaralhos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formVisualizarBaralhos));
            this.btnAdicionarBaralho = new System.Windows.Forms.Button();
            this.btnEditarBaralho = new System.Windows.Forms.Button();
            this.btnRemoverBaralho = new System.Windows.Forms.Button();
            this.panelVisualizarBaralhos = new System.Windows.Forms.Panel();
            this.btnRevisarBaralho = new System.Windows.Forms.Button();
            this.btnBaralho1 = new System.Windows.Forms.Button();
            this.btnBaralho2 = new System.Windows.Forms.Button();
            this.btnBaralho3 = new System.Windows.Forms.Button();
            this.panelVisualizarBaralhos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarBaralho
            // 
            this.btnAdicionarBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnAdicionarBaralho, "btnAdicionarBaralho");
            this.btnAdicionarBaralho.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionarBaralho.Name = "btnAdicionarBaralho";
            this.btnAdicionarBaralho.UseVisualStyleBackColor = false;
            this.btnAdicionarBaralho.Click += new System.EventHandler(this.btnAdicionarBaralho_Click);
            // 
            // btnEditarBaralho
            // 
            this.btnEditarBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnEditarBaralho, "btnEditarBaralho");
            this.btnEditarBaralho.ForeColor = System.Drawing.Color.White;
            this.btnEditarBaralho.Name = "btnEditarBaralho";
            this.btnEditarBaralho.UseVisualStyleBackColor = false;
            this.btnEditarBaralho.Click += new System.EventHandler(this.btnEditarBaralho_Click);
            // 
            // btnRemoverBaralho
            // 
            this.btnRemoverBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.btnRemoverBaralho, "btnRemoverBaralho");
            this.btnRemoverBaralho.ForeColor = System.Drawing.Color.White;
            this.btnRemoverBaralho.Name = "btnRemoverBaralho";
            this.btnRemoverBaralho.UseVisualStyleBackColor = false;
            // 
            // panelVisualizarBaralhos
            // 
            this.panelVisualizarBaralhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelVisualizarBaralhos.Controls.Add(this.btnRevisarBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnAdicionarBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnRemoverBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnEditarBaralho);
            resources.ApplyResources(this.panelVisualizarBaralhos, "panelVisualizarBaralhos");
            this.panelVisualizarBaralhos.Name = "panelVisualizarBaralhos";
            // 
            // btnRevisarBaralho
            // 
            resources.ApplyResources(this.btnRevisarBaralho, "btnRevisarBaralho");
            this.btnRevisarBaralho.Name = "btnRevisarBaralho";
            this.btnRevisarBaralho.UseVisualStyleBackColor = true;
            this.btnRevisarBaralho.Click += new System.EventHandler(this.btnRevisarBaralho_Click_1);
            // 
            // btnBaralho1
            // 
            this.btnBaralho1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.btnBaralho1, "btnBaralho1");
            this.btnBaralho1.Name = "btnBaralho1";
            this.btnBaralho1.UseVisualStyleBackColor = false;
            this.btnBaralho1.Click += new System.EventHandler(this.btnBaralho1_Click);
            // 
            // btnBaralho2
            // 
            this.btnBaralho2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.btnBaralho2, "btnBaralho2");
            this.btnBaralho2.Name = "btnBaralho2";
            this.btnBaralho2.UseVisualStyleBackColor = false;
            this.btnBaralho2.Click += new System.EventHandler(this.btnBaralho2_Click);
            // 
            // btnBaralho3
            // 
            this.btnBaralho3.BackColor = System.Drawing.Color.Cyan;
            resources.ApplyResources(this.btnBaralho3, "btnBaralho3");
            this.btnBaralho3.Name = "btnBaralho3";
            this.btnBaralho3.UseVisualStyleBackColor = false;
            this.btnBaralho3.Click += new System.EventHandler(this.btnBaralho3_Click);
            // 
            // formVisualizarBaralhos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.btnBaralho3);
            this.Controls.Add(this.btnBaralho2);
            this.Controls.Add(this.btnBaralho1);
            this.Controls.Add(this.panelVisualizarBaralhos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formVisualizarBaralhos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelVisualizarBaralhos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAdicionarBaralho;
        private Button btnEditarBaralho;
        private Button btnRemoverBaralho;
        private Panel panelVisualizarBaralhos;
        private Button btnBaralho1;
        private Button btnBaralho2;
        private Button btnBaralho3;
        private Button btnRevisarBaralho;
    }
}
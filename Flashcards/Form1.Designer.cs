namespace Flashcards
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBaralhos = new System.Windows.Forms.ListBox();
            this.btnAdicionarBaralho = new System.Windows.Forms.Button();
            this.btnEditarBaralho = new System.Windows.Forms.Button();
            this.btnRemoverBaralho = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloBaralhos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBaralhos
            // 
            this.listBaralhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.listBaralhos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBaralhos.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.listBaralhos.ForeColor = System.Drawing.Color.White;
            this.listBaralhos.FormattingEnabled = true;
            this.listBaralhos.ItemHeight = 17;
            this.listBaralhos.Items.AddRange(new object[] {
            "Baralho1",
            "Baralho2",
            "Baralho3"});
            this.listBaralhos.Location = new System.Drawing.Point(748, 164);
            this.listBaralhos.Name = "listBaralhos";
            this.listBaralhos.Size = new System.Drawing.Size(85, 136);
            this.listBaralhos.TabIndex = 0;
            // 
            // btnAdicionarBaralho
            // 
            this.btnAdicionarBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAdicionarBaralho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionarBaralho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBaralho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarBaralho.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdicionarBaralho.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarBaralho.Image")));
            this.btnAdicionarBaralho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarBaralho.Location = new System.Drawing.Point(69, 3);
            this.btnAdicionarBaralho.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdicionarBaralho.Name = "btnAdicionarBaralho";
            this.btnAdicionarBaralho.Size = new System.Drawing.Size(160, 50);
            this.btnAdicionarBaralho.TabIndex = 2;
            this.btnAdicionarBaralho.Text = "Adicionar Baralho";
            this.btnAdicionarBaralho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarBaralho.UseVisualStyleBackColor = false;
            this.btnAdicionarBaralho.Click += new System.EventHandler(this.btnAdicionarBaralho_Click);
            // 
            // btnEditarBaralho
            // 
            this.btnEditarBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnEditarBaralho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarBaralho.ForeColor = System.Drawing.Color.White;
            this.btnEditarBaralho.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarBaralho.Image")));
            this.btnEditarBaralho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarBaralho.Location = new System.Drawing.Point(232, 3);
            this.btnEditarBaralho.Name = "btnEditarBaralho";
            this.btnEditarBaralho.Size = new System.Drawing.Size(160, 50);
            this.btnEditarBaralho.TabIndex = 3;
            this.btnEditarBaralho.Text = "Editar Baralho";
            this.btnEditarBaralho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarBaralho.UseVisualStyleBackColor = false;
            this.btnEditarBaralho.Click += new System.EventHandler(this.btnEditarBaralho_Click);
            // 
            // btnRemoverBaralho
            // 
            this.btnRemoverBaralho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnRemoverBaralho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverBaralho.ForeColor = System.Drawing.Color.White;
            this.btnRemoverBaralho.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverBaralho.Image")));
            this.btnRemoverBaralho.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverBaralho.Location = new System.Drawing.Point(398, 3);
            this.btnRemoverBaralho.Name = "btnRemoverBaralho";
            this.btnRemoverBaralho.Size = new System.Drawing.Size(160, 50);
            this.btnRemoverBaralho.TabIndex = 4;
            this.btnRemoverBaralho.Text = "Remover Baralho";
            this.btnRemoverBaralho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverBaralho.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.ferramentasToolStripMenuItem1,
            this.sobreToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem1.Text = "Editar";
            // 
            // ferramentasToolStripMenuItem1
            // 
            this.ferramentasToolStripMenuItem1.Name = "ferramentasToolStripMenuItem1";
            this.ferramentasToolStripMenuItem1.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem1.Text = "Ferramentas";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btnAdicionarBaralho);
            this.panel1.Controls.Add(this.btnRemoverBaralho);
            this.panel1.Controls.Add(this.btnEditarBaralho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 56);
            this.panel1.TabIndex = 8;
            // 
            // lblTituloBaralhos
            // 
            this.lblTituloBaralhos.AutoSize = true;
            this.lblTituloBaralhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblTituloBaralhos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloBaralhos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloBaralhos.Image = ((System.Drawing.Image)(resources.GetObject("lblTituloBaralhos.Image")));
            this.lblTituloBaralhos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTituloBaralhos.Location = new System.Drawing.Point(727, 129);
            this.lblTituloBaralhos.Name = "lblTituloBaralhos";
            this.lblTituloBaralhos.Size = new System.Drawing.Size(120, 21);
            this.lblTituloBaralhos.TabIndex = 1;
            this.lblTituloBaralhos.Text = "Baralhos           ";
            this.lblTituloBaralhos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.Location = new System.Drawing.Point(69, 129);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(857, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTituloBaralhos);
            this.Controls.Add(this.listBaralhos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "formMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBaralhos;
        private Button btnAdicionarBaralho;
        private Button btnEditarBaralho;
        private Button btnRemoverBaralho;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivosToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem ferramentasToolStripMenuItem1;
        private ToolStripMenuItem sobreToolStripMenuItem1;
        private Panel panel1;
        private Label lblTituloBaralhos;
        private DataGridView dataGridView1;
    }
}
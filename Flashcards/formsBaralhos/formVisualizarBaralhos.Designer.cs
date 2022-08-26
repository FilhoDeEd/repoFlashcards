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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBaralhos = new System.Windows.Forms.ListBox();
            this.btnAdicionarBaralho = new System.Windows.Forms.Button();
            this.btnEditarBaralho = new System.Windows.Forms.Button();
            this.btnRemoverBaralho = new System.Windows.Forms.Button();
            this.panelVisualizarBaralhos = new System.Windows.Forms.Panel();
            this.lblTituloBaralhos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelVisualizarBaralhos.SuspendLayout();
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
            // panelVisualizarBaralhos
            // 
            this.panelVisualizarBaralhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelVisualizarBaralhos.Controls.Add(this.btnAdicionarBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnRemoverBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnEditarBaralho);
            this.panelVisualizarBaralhos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVisualizarBaralhos.Location = new System.Drawing.Point(0, 0);
            this.panelVisualizarBaralhos.Name = "panelVisualizarBaralhos";
            this.panelVisualizarBaralhos.Size = new System.Drawing.Size(857, 56);
            this.panelVisualizarBaralhos.TabIndex = 8;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(69, 129);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 240);
            this.dataGridView1.TabIndex = 9;
            // 
            // formVisualizarBaralhos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(857, 495);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelVisualizarBaralhos);
            this.Controls.Add(this.lblTituloBaralhos);
            this.Controls.Add(this.listBaralhos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formVisualizarBaralhos";
            this.panelVisualizarBaralhos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBaralhos;
        private Button btnAdicionarBaralho;
        private Button btnEditarBaralho;
        private Button btnRemoverBaralho;
        private Panel panelVisualizarBaralhos;
        private Label lblTituloBaralhos;
        private DataGridView dataGridView1;
    }
}
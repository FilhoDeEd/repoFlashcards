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
            resources.ApplyResources(this.listBaralhos, "listBaralhos");
            this.listBaralhos.ForeColor = System.Drawing.Color.White;
            this.listBaralhos.FormattingEnabled = true;
            this.listBaralhos.Items.AddRange(new object[] {
            resources.GetString("listBaralhos.Items"),
            resources.GetString("listBaralhos.Items1"),
            resources.GetString("listBaralhos.Items2")});
            this.listBaralhos.Name = "listBaralhos";
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
            this.panelVisualizarBaralhos.Controls.Add(this.btnAdicionarBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnRemoverBaralho);
            this.panelVisualizarBaralhos.Controls.Add(this.btnEditarBaralho);
            resources.ApplyResources(this.panelVisualizarBaralhos, "panelVisualizarBaralhos");
            this.panelVisualizarBaralhos.Name = "panelVisualizarBaralhos";
            // 
            // lblTituloBaralhos
            // 
            resources.ApplyResources(this.lblTituloBaralhos, "lblTituloBaralhos");
            this.lblTituloBaralhos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblTituloBaralhos.ForeColor = System.Drawing.Color.Black;
            this.lblTituloBaralhos.Name = "lblTituloBaralhos";
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
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
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
            // 
            // formVisualizarBaralhos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelVisualizarBaralhos);
            this.Controls.Add(this.lblTituloBaralhos);
            this.Controls.Add(this.listBaralhos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formVisualizarBaralhos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
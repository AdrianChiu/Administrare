namespace AdministrareAsociatie
{
    partial class ListedePlataLunare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListedePlataLunare));
            this.DeschidereListeDePlataLunareButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AnLuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inchisa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeschidereListeDePlataLunareButton
            // 
            this.DeschidereListeDePlataLunareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeschidereListeDePlataLunareButton.Image = ((System.Drawing.Image)(resources.GetObject("DeschidereListeDePlataLunareButton.Image")));
            this.DeschidereListeDePlataLunareButton.Location = new System.Drawing.Point(13, 13);
            this.DeschidereListeDePlataLunareButton.Name = "DeschidereListeDePlataLunareButton";
            this.DeschidereListeDePlataLunareButton.Size = new System.Drawing.Size(148, 41);
            this.DeschidereListeDePlataLunareButton.TabIndex = 0;
            this.DeschidereListeDePlataLunareButton.Text = "Deschidere";
            this.DeschidereListeDePlataLunareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeschidereListeDePlataLunareButton.UseVisualStyleBackColor = true;
            this.DeschidereListeDePlataLunareButton.Click += new System.EventHandler(this.DeschidereListeDePlataLunareButton_Click);
            // 
            // IesireButton
            // 
            this.IesireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IesireButton.Image = ((System.Drawing.Image)(resources.GetObject("IesireButton.Image")));
            this.IesireButton.Location = new System.Drawing.Point(318, 335);
            this.IesireButton.Name = "IesireButton";
            this.IesireButton.Size = new System.Drawing.Size(87, 23);
            this.IesireButton.TabIndex = 1;
            this.IesireButton.Text = "Iesire";
            this.IesireButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.IesireButton.UseVisualStyleBackColor = true;
            this.IesireButton.Click += new System.EventHandler(this.IesireButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AnLuna,
            this.Inchisa});
            this.dataGridView1.Location = new System.Drawing.Point(13, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(392, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // AnLuna
            // 
            this.AnLuna.HeaderText = "An, luna";
            this.AnLuna.Name = "AnLuna";
            // 
            // Inchisa
            // 
            this.Inchisa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Inchisa.HeaderText = "Inchisa";
            this.Inchisa.Name = "Inchisa";
            // 
            // ListedePlataLunare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.DeschidereListeDePlataLunareButton);
            this.Name = "ListedePlataLunare";
            this.Text = "Liste de Plata Lunare";
            this.Load += new System.EventHandler(this.ListedePlataLunare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeschidereListeDePlataLunareButton;
        private System.Windows.Forms.Button IesireButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnLuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inchisa;
    }
}
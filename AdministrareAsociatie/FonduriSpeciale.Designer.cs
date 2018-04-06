namespace AdministrareAsociatie
{
    partial class FonduriSpeciale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FonduriSpeciale));
            this.AdaugareButton = new System.Windows.Forms.Button();
            this.DeschidereButton = new System.Windows.Forms.Button();
            this.StergereButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nul = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugareButton
            // 
            this.AdaugareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareButton.Image = ((System.Drawing.Image)(resources.GetObject("AdaugareButton.Image")));
            this.AdaugareButton.Location = new System.Drawing.Point(13, 13);
            this.AdaugareButton.Name = "AdaugareButton";
            this.AdaugareButton.Size = new System.Drawing.Size(128, 44);
            this.AdaugareButton.TabIndex = 0;
            this.AdaugareButton.Text = "Adaugare";
            this.AdaugareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AdaugareButton.UseVisualStyleBackColor = true;
            this.AdaugareButton.Click += new System.EventHandler(this.AdaugareButton_Click);
            // 
            // DeschidereButton
            // 
            this.DeschidereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeschidereButton.Image = ((System.Drawing.Image)(resources.GetObject("DeschidereButton.Image")));
            this.DeschidereButton.Location = new System.Drawing.Point(147, 13);
            this.DeschidereButton.Name = "DeschidereButton";
            this.DeschidereButton.Size = new System.Drawing.Size(128, 44);
            this.DeschidereButton.TabIndex = 0;
            this.DeschidereButton.Text = "Deschidere";
            this.DeschidereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeschidereButton.UseVisualStyleBackColor = true;
            this.DeschidereButton.Click += new System.EventHandler(this.DeschidereButton_Click);
            // 
            // StergereButton
            // 
            this.StergereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StergereButton.Image = ((System.Drawing.Image)(resources.GetObject("StergereButton.Image")));
            this.StergereButton.Location = new System.Drawing.Point(281, 13);
            this.StergereButton.Name = "StergereButton";
            this.StergereButton.Size = new System.Drawing.Size(128, 44);
            this.StergereButton.TabIndex = 0;
            this.StergereButton.Text = "Stergere";
            this.StergereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StergereButton.UseVisualStyleBackColor = true;
            this.StergereButton.Click += new System.EventHandler(this.StergereButton_Click);
            // 
            // IesireButton
            // 
            this.IesireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IesireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IesireButton.Image = ((System.Drawing.Image)(resources.GetObject("IesireButton.Image")));
            this.IesireButton.Location = new System.Drawing.Point(358, 368);
            this.IesireButton.Name = "IesireButton";
            this.IesireButton.Size = new System.Drawing.Size(75, 23);
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
            this.Denumire,
            this.nul});
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 298);
            this.dataGridView1.TabIndex = 2;
            // 
            // Denumire
            // 
            this.Denumire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.Name = "Denumire";
            // 
            // nul
            // 
            this.nul.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nul.HeaderText = "";
            this.nul.Name = "nul";
            // 
            // FonduriSpeciale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 403);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.StergereButton);
            this.Controls.Add(this.DeschidereButton);
            this.Controls.Add(this.AdaugareButton);
            this.Name = "FonduriSpeciale";
            this.Text = "Fonduri speciale";
            this.Load += new System.EventHandler(this.FonduriSpeciale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugareButton;
        private System.Windows.Forms.Button DeschidereButton;
        private System.Windows.Forms.Button StergereButton;
        private System.Windows.Forms.Button IesireButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn nul;
    }
}
namespace AdministrareAsociatie
{
    partial class ConturiBancare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConturiBancare));
            this.AdaugareButton = new System.Windows.Forms.Button();
            this.DeschidereButton = new System.Windows.Forms.Button();
            this.StergereButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugareButton
            // 
            this.AdaugareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareButton.Image = ((System.Drawing.Image)(resources.GetObject("AdaugareButton.Image")));
            this.AdaugareButton.Location = new System.Drawing.Point(13, 13);
            this.AdaugareButton.Name = "AdaugareButton";
            this.AdaugareButton.Size = new System.Drawing.Size(132, 52);
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
            this.DeschidereButton.Location = new System.Drawing.Point(151, 13);
            this.DeschidereButton.Name = "DeschidereButton";
            this.DeschidereButton.Size = new System.Drawing.Size(132, 52);
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
            this.StergereButton.Location = new System.Drawing.Point(289, 13);
            this.StergereButton.Name = "StergereButton";
            this.StergereButton.Size = new System.Drawing.Size(132, 52);
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
            this.IesireButton.Location = new System.Drawing.Point(683, 448);
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 370);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // ConturiBancare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 483);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.StergereButton);
            this.Controls.Add(this.DeschidereButton);
            this.Controls.Add(this.AdaugareButton);
            this.Name = "ConturiBancare";
            this.Text = "Conturi Bancare";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugareButton;
        private System.Windows.Forms.Button DeschidereButton;
        private System.Windows.Forms.Button StergereButton;
        private System.Windows.Forms.Button IesireButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
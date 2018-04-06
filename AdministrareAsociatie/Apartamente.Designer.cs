namespace AdministrareAsociatie
{
    partial class Apartamente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apartamente));
            this.AdaugareButton = new System.Windows.Forms.Button();
            this.DeschideButton = new System.Windows.Forms.Button();
            this.StergereButton = new System.Windows.Forms.Button();
            this.ListaApartamenteButton = new System.Windows.Forms.Button();
            this.IesireButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etaj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proprietar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrCamere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuprUtila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CotaIndiviza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdaugareButton
            // 
            this.AdaugareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdaugareButton.Image = ((System.Drawing.Image)(resources.GetObject("AdaugareButton.Image")));
            this.AdaugareButton.Location = new System.Drawing.Point(13, 13);
            this.AdaugareButton.Name = "AdaugareButton";
            this.AdaugareButton.Size = new System.Drawing.Size(118, 45);
            this.AdaugareButton.TabIndex = 0;
            this.AdaugareButton.Text = "Adaugare";
            this.AdaugareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AdaugareButton.UseVisualStyleBackColor = true;
            this.AdaugareButton.Click += new System.EventHandler(this.AdaugareButton_Click);
            // 
            // DeschideButton
            // 
            this.DeschideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeschideButton.Image = ((System.Drawing.Image)(resources.GetObject("DeschideButton.Image")));
            this.DeschideButton.Location = new System.Drawing.Point(137, 13);
            this.DeschideButton.Name = "DeschideButton";
            this.DeschideButton.Size = new System.Drawing.Size(118, 45);
            this.DeschideButton.TabIndex = 0;
            this.DeschideButton.Text = "Deschide";
            this.DeschideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.DeschideButton.UseVisualStyleBackColor = true;
            this.DeschideButton.Click += new System.EventHandler(this.DeschideButton_Click);
            // 
            // StergereButton
            // 
            this.StergereButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StergereButton.Image = ((System.Drawing.Image)(resources.GetObject("StergereButton.Image")));
            this.StergereButton.Location = new System.Drawing.Point(261, 13);
            this.StergereButton.Name = "StergereButton";
            this.StergereButton.Size = new System.Drawing.Size(118, 45);
            this.StergereButton.TabIndex = 0;
            this.StergereButton.Text = "Stergere";
            this.StergereButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.StergereButton.UseVisualStyleBackColor = true;
            this.StergereButton.Click += new System.EventHandler(this.StergereButton_Click);
            // 
            // ListaApartamenteButton
            // 
            this.ListaApartamenteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ListaApartamenteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaApartamenteButton.Location = new System.Drawing.Point(12, 531);
            this.ListaApartamenteButton.Name = "ListaApartamenteButton";
            this.ListaApartamenteButton.Size = new System.Drawing.Size(190, 27);
            this.ListaApartamenteButton.TabIndex = 1;
            this.ListaApartamenteButton.Text = "Lista apartamente";
            this.ListaApartamenteButton.UseVisualStyleBackColor = true;
            // 
            // IesireButton
            // 
            this.IesireButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IesireButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IesireButton.Image = ((System.Drawing.Image)(resources.GetObject("IesireButton.Image")));
            this.IesireButton.Location = new System.Drawing.Point(817, 533);
            this.IesireButton.Name = "IesireButton";
            this.IesireButton.Size = new System.Drawing.Size(103, 23);
            this.IesireButton.TabIndex = 2;
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
            this.NR,
            this.Scara,
            this.Etaj,
            this.Proprietar,
            this.NrCamere,
            this.SuprUtila,
            this.CotaIndiviza,
            this.NrPers});
            this.dataGridView1.Location = new System.Drawing.Point(13, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 452);
            this.dataGridView1.TabIndex = 3;
            // 
            // NR
            // 
            this.NR.HeaderText = "Nr.";
            this.NR.Name = "NR";
            // 
            // Scara
            // 
            this.Scara.HeaderText = "Scara";
            this.Scara.Name = "Scara";
            // 
            // Etaj
            // 
            this.Etaj.HeaderText = "Etaj";
            this.Etaj.Name = "Etaj";
            // 
            // Proprietar
            // 
            this.Proprietar.HeaderText = "Proprietar";
            this.Proprietar.Name = "Proprietar";
            // 
            // NrCamere
            // 
            this.NrCamere.HeaderText = "Nr camere";
            this.NrCamere.Name = "NrCamere";
            // 
            // SuprUtila
            // 
            this.SuprUtila.HeaderText = "Supr. utila";
            this.SuprUtila.Name = "SuprUtila";
            // 
            // CotaIndiviza
            // 
            this.CotaIndiviza.HeaderText = "Cota indiviza";
            this.CotaIndiviza.Name = "CotaIndiviza";
            // 
            // NrPers
            // 
            this.NrPers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NrPers.HeaderText = "Nr. pers";
            this.NrPers.Name = "NrPers";
            // 
            // Apartamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 568);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IesireButton);
            this.Controls.Add(this.ListaApartamenteButton);
            this.Controls.Add(this.StergereButton);
            this.Controls.Add(this.DeschideButton);
            this.Controls.Add(this.AdaugareButton);
            this.Name = "Apartamente";
            this.Text = "Apartamente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugareButton;
        private System.Windows.Forms.Button DeschideButton;
        private System.Windows.Forms.Button StergereButton;
        private System.Windows.Forms.Button ListaApartamenteButton;
        private System.Windows.Forms.Button IesireButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proprietar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrCamere;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuprUtila;
        private System.Windows.Forms.DataGridViewTextBoxColumn CotaIndiviza;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPers;
    }
}
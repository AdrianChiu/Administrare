﻿namespace AdministrareAsociatie
{
    partial class PersoaneFiziceJuridice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersoaneFiziceJuridice));
            this.AdaugareButton = new System.Windows.Forms.Button();
            this.DeschidereButton = new System.Windows.Forms.Button();
            this.StergereButton = new System.Windows.Forms.Button();
            this.Iesirebutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denumire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUICNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltruTipPersoanaComboBox = new System.Windows.Forms.ComboBox();
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
            // Iesirebutton
            // 
            this.Iesirebutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Iesirebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iesirebutton.Image = ((System.Drawing.Image)(resources.GetObject("Iesirebutton.Image")));
            this.Iesirebutton.Location = new System.Drawing.Point(526, 412);
            this.Iesirebutton.Name = "Iesirebutton";
            this.Iesirebutton.Size = new System.Drawing.Size(75, 23);
            this.Iesirebutton.TabIndex = 1;
            this.Iesirebutton.Text = "Iesire";
            this.Iesirebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Iesirebutton.UseVisualStyleBackColor = true;
            this.Iesirebutton.Click += new System.EventHandler(this.Iesirebutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tip,
            this.Denumire,
            this.CUICNP});
            this.dataGridView1.Location = new System.Drawing.Point(13, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            // 
            // Denumire
            // 
            this.Denumire.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Denumire.HeaderText = "Denumire";
            this.Denumire.Name = "Denumire";
            // 
            // CUICNP
            // 
            this.CUICNP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUICNP.HeaderText = "CUI/CNP";
            this.CUICNP.Name = "CUICNP";
            // 
            // FiltruTipPersoanaComboBox
            // 
            this.FiltruTipPersoanaComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltruTipPersoanaComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Clienti",
            "Creditori garantii",
            "Creditori diversi",
            "Debitori avansuri decontare",
            "Debitori diversi",
            "Furnizori ",
            "Proprietari"});
            this.FiltruTipPersoanaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltruTipPersoanaComboBox.FormattingEnabled = true;
            this.FiltruTipPersoanaComboBox.Location = new System.Drawing.Point(480, 33);
            this.FiltruTipPersoanaComboBox.Name = "FiltruTipPersoanaComboBox";
            this.FiltruTipPersoanaComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltruTipPersoanaComboBox.TabIndex = 3;
            this.FiltruTipPersoanaComboBox.Text = "Filtru: tip persoana";
            // 
            // PersoaneFiziceJuridice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 447);
            this.Controls.Add(this.FiltruTipPersoanaComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Iesirebutton);
            this.Controls.Add(this.StergereButton);
            this.Controls.Add(this.DeschidereButton);
            this.Controls.Add(this.AdaugareButton);
            this.Name = "PersoaneFiziceJuridice";
            this.Text = "Persoane Fizice - Juridice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdaugareButton;
        private System.Windows.Forms.Button DeschidereButton;
        private System.Windows.Forms.Button StergereButton;
        private System.Windows.Forms.Button Iesirebutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denumire;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUICNP;
        private System.Windows.Forms.ComboBox FiltruTipPersoanaComboBox;
    }
}
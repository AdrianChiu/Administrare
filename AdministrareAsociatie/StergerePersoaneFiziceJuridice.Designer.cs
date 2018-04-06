namespace AdministrareAsociatie
{
    partial class StergerePersoaneFiziceJuridice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StergerePersoaneFiziceJuridice));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TipPersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RevocareSPButton = new System.Windows.Forms.Button();
            this.OKSPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(107, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 14;
            // 
            // TipPersLabel
            // 
            this.TipPersLabel.AutoSize = true;
            this.TipPersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPersLabel.Location = new System.Drawing.Point(12, 9);
            this.TipPersLabel.Name = "TipPersLabel";
            this.TipPersLabel.Size = new System.Drawing.Size(89, 16);
            this.TipPersLabel.TabIndex = 10;
            this.TipPersLabel.Text = "Tip persoana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "CUI / CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Denumire";
            // 
            // RevocareSPButton
            // 
            this.RevocareSPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareSPButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareSPButton.Image")));
            this.RevocareSPButton.Location = new System.Drawing.Point(336, 114);
            this.RevocareSPButton.Name = "RevocareSPButton";
            this.RevocareSPButton.Size = new System.Drawing.Size(75, 23);
            this.RevocareSPButton.TabIndex = 15;
            this.RevocareSPButton.Text = "Revocare";
            this.RevocareSPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareSPButton.UseVisualStyleBackColor = true;
            this.RevocareSPButton.Click += new System.EventHandler(this.RevocareSPButton_Click);
            // 
            // OKSPButton
            // 
            this.OKSPButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKSPButton.Image = ((System.Drawing.Image)(resources.GetObject("OKSPButton.Image")));
            this.OKSPButton.Location = new System.Drawing.Point(255, 114);
            this.OKSPButton.Name = "OKSPButton";
            this.OKSPButton.Size = new System.Drawing.Size(75, 23);
            this.OKSPButton.TabIndex = 15;
            this.OKSPButton.Text = "OK";
            this.OKSPButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKSPButton.UseVisualStyleBackColor = true;
            // 
            // StergerePersoaneFiziceJuridice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 152);
            this.Controls.Add(this.OKSPButton);
            this.Controls.Add(this.RevocareSPButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TipPersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StergerePersoaneFiziceJuridice";
            this.Text = "StergerePersoaneFiziceJuridice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TipPersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RevocareSPButton;
        private System.Windows.Forms.Button OKSPButton;
    }
}
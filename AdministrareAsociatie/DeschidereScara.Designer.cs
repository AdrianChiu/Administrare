namespace AdministrareAsociatie
{
    partial class DeschidereScara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeschidereScara));
            this.ScaraDLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RevocareDButton = new System.Windows.Forms.Button();
            this.OKDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScaraDLabel
            // 
            this.ScaraDLabel.AutoSize = true;
            this.ScaraDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaraDLabel.Location = new System.Drawing.Point(13, 13);
            this.ScaraDLabel.Name = "ScaraDLabel";
            this.ScaraDLabel.Size = new System.Drawing.Size(44, 16);
            this.ScaraDLabel.TabIndex = 0;
            this.ScaraDLabel.Text = "Scara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // RevocareDButton
            // 
            this.RevocareDButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareDButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareDButton.Image")));
            this.RevocareDButton.Location = new System.Drawing.Point(194, 81);
            this.RevocareDButton.Name = "RevocareDButton";
            this.RevocareDButton.Size = new System.Drawing.Size(75, 23);
            this.RevocareDButton.TabIndex = 2;
            this.RevocareDButton.Text = "Revocare";
            this.RevocareDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareDButton.UseVisualStyleBackColor = true;
            this.RevocareDButton.Click += new System.EventHandler(this.RevocareDButton_Click);
            // 
            // OKDButton
            // 
            this.OKDButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKDButton.Image = ((System.Drawing.Image)(resources.GetObject("OKDButton.Image")));
            this.OKDButton.Location = new System.Drawing.Point(113, 81);
            this.OKDButton.Name = "OKDButton";
            this.OKDButton.Size = new System.Drawing.Size(75, 23);
            this.OKDButton.TabIndex = 2;
            this.OKDButton.Text = "OK";
            this.OKDButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKDButton.UseVisualStyleBackColor = true;
            // 
            // DeschidereScara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 116);
            this.Controls.Add(this.OKDButton);
            this.Controls.Add(this.RevocareDButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ScaraDLabel);
            this.Name = "DeschidereScara";
            this.Text = "Deschidere Scara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScaraDLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RevocareDButton;
        private System.Windows.Forms.Button OKDButton;
    }
}
namespace AdministrareAsociatie
{
    partial class StergereScara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StergereScara));
            this.ScaraSLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OKSButton = new System.Windows.Forms.Button();
            this.RevocareSButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScaraSLabel
            // 
            this.ScaraSLabel.AutoSize = true;
            this.ScaraSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaraSLabel.Location = new System.Drawing.Point(13, 13);
            this.ScaraSLabel.Name = "ScaraSLabel";
            this.ScaraSLabel.Size = new System.Drawing.Size(44, 16);
            this.ScaraSLabel.TabIndex = 0;
            this.ScaraSLabel.Text = "Scara";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 1;
            // 
            // OKSButton
            // 
            this.OKSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKSButton.Image = ((System.Drawing.Image)(resources.GetObject("OKSButton.Image")));
            this.OKSButton.Location = new System.Drawing.Point(131, 80);
            this.OKSButton.Name = "OKSButton";
            this.OKSButton.Size = new System.Drawing.Size(75, 23);
            this.OKSButton.TabIndex = 2;
            this.OKSButton.Text = "OK";
            this.OKSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKSButton.UseVisualStyleBackColor = true;
            // 
            // RevocareSButton
            // 
            this.RevocareSButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareSButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareSButton.Image")));
            this.RevocareSButton.Location = new System.Drawing.Point(212, 80);
            this.RevocareSButton.Name = "RevocareSButton";
            this.RevocareSButton.Size = new System.Drawing.Size(75, 23);
            this.RevocareSButton.TabIndex = 2;
            this.RevocareSButton.Text = "Revocare";
            this.RevocareSButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareSButton.UseVisualStyleBackColor = true;
            this.RevocareSButton.Click += new System.EventHandler(this.RevocareSButton_Click);
            // 
            // StergereScara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 115);
            this.Controls.Add(this.RevocareSButton);
            this.Controls.Add(this.OKSButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ScaraSLabel);
            this.Name = "StergereScara";
            this.Text = "Stergere Scara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScaraSLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OKSButton;
        private System.Windows.Forms.Button RevocareSButton;
    }
}
namespace AdministrareAsociatie
{
    partial class AdaugareScara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareScara));
            this.ScaraLabel = new System.Windows.Forms.Label();
            this.ScaraTextBox = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.RevocareButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScaraLabel
            // 
            this.ScaraLabel.AutoSize = true;
            this.ScaraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaraLabel.Location = new System.Drawing.Point(13, 13);
            this.ScaraLabel.Name = "ScaraLabel";
            this.ScaraLabel.Size = new System.Drawing.Size(44, 16);
            this.ScaraLabel.TabIndex = 0;
            this.ScaraLabel.Text = "Scara";
            // 
            // ScaraTextBox
            // 
            this.ScaraTextBox.Location = new System.Drawing.Point(64, 8);
            this.ScaraTextBox.Name = "ScaraTextBox";
            this.ScaraTextBox.Size = new System.Drawing.Size(122, 20);
            this.ScaraTextBox.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Image = ((System.Drawing.Image)(resources.GetObject("OKButton.Image")));
            this.OKButton.Location = new System.Drawing.Point(90, 58);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // RevocareButton
            // 
            this.RevocareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevocareButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareButton.Image")));
            this.RevocareButton.Location = new System.Drawing.Point(171, 58);
            this.RevocareButton.Name = "RevocareButton";
            this.RevocareButton.Size = new System.Drawing.Size(75, 23);
            this.RevocareButton.TabIndex = 2;
            this.RevocareButton.Text = "Revocare";
            this.RevocareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareButton.UseVisualStyleBackColor = true;
            this.RevocareButton.Click += new System.EventHandler(this.RevocareButton_Click);
            // 
            // AdaugareScara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 93);
            this.Controls.Add(this.RevocareButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ScaraTextBox);
            this.Controls.Add(this.ScaraLabel);
            this.Name = "AdaugareScara";
            this.Text = "Adaugare Scara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScaraLabel;
        private System.Windows.Forms.TextBox ScaraTextBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RevocareButton;
    }
}
namespace AdministrareAsociatie
{
    partial class AdaugarePersoaneFiziceJuridice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugarePersoaneFiziceJuridice));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.RevocareButton = new System.Windows.Forms.Button();
            this.TipPersLabel = new System.Windows.Forms.Label();
            this.TipPersCcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(110, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(309, 22);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(110, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CUI / CNP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Denumire";
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Image = ((System.Drawing.Image)(resources.GetObject("OKButton.Image")));
            this.OKButton.Location = new System.Drawing.Point(270, 124);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // RevocareButton
            // 
            this.RevocareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareButton.Image")));
            this.RevocareButton.Location = new System.Drawing.Point(351, 124);
            this.RevocareButton.Name = "RevocareButton";
            this.RevocareButton.Size = new System.Drawing.Size(75, 23);
            this.RevocareButton.TabIndex = 4;
            this.RevocareButton.Text = "Revocare";
            this.RevocareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareButton.UseVisualStyleBackColor = true;
            this.RevocareButton.Click += new System.EventHandler(this.RevocareButton_Click);
            // 
            // TipPersLabel
            // 
            this.TipPersLabel.AutoSize = true;
            this.TipPersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPersLabel.Location = new System.Drawing.Point(14, 15);
            this.TipPersLabel.Name = "TipPersLabel";
            this.TipPersLabel.Size = new System.Drawing.Size(89, 16);
            this.TipPersLabel.TabIndex = 6;
            this.TipPersLabel.Text = "Tip persoana";
            // 
            // TipPersCcomboBox
            // 
            this.TipPersCcomboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Proprietari",
            "Furnizori",
            "Clienti",
            "Debitori avansuri decontare",
            "Debitori diversi",
            "Creditori garantii",
            "Creditori diversi"});
            this.TipPersCcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipPersCcomboBox.FormattingEnabled = true;
            this.TipPersCcomboBox.Location = new System.Drawing.Point(110, 15);
            this.TipPersCcomboBox.Name = "TipPersCcomboBox";
            this.TipPersCcomboBox.Size = new System.Drawing.Size(308, 24);
            this.TipPersCcomboBox.TabIndex = 9;
            // 
            // AdaugarePersoaneFiziceJuridice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 159);
            this.Controls.Add(this.TipPersCcomboBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TipPersLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RevocareButton);
            this.Name = "AdaugarePersoaneFiziceJuridice";
            this.Text = "Adaugare Persoane Fizice Juridice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RevocareButton;
        private System.Windows.Forms.Label TipPersLabel;
        private System.Windows.Forms.ComboBox TipPersCcomboBox;
    }
}
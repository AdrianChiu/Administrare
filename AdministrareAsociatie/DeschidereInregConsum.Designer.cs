namespace AdministrareAsociatie
{
    partial class DeschidereInregConsum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeschidereInregConsum));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BorderouConsumInregistratButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.RevocareButton = new System.Windows.Forms.Button();
            this.BorderouColectareConsumButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Apartament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NrPers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IndecsApaRece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2018, 4, 24, 23, 59, 59, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(325, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Se inreg consumul de pe contoarele din apartamente.";
            // 
            // BorderouConsumInregistratButton
            // 
            this.BorderouConsumInregistratButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorderouConsumInregistratButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderouConsumInregistratButton.Image = ((System.Drawing.Image)(resources.GetObject("BorderouConsumInregistratButton.Image")));
            this.BorderouConsumInregistratButton.Location = new System.Drawing.Point(12, 642);
            this.BorderouConsumInregistratButton.Name = "BorderouConsumInregistratButton";
            this.BorderouConsumInregistratButton.Size = new System.Drawing.Size(212, 39);
            this.BorderouConsumInregistratButton.TabIndex = 2;
            this.BorderouConsumInregistratButton.Text = "Borderou consum inregistrat";
            this.BorderouConsumInregistratButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorderouConsumInregistratButton.UseVisualStyleBackColor = true;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Image = ((System.Drawing.Image)(resources.GetObject("OKButton.Image")));
            this.OKButton.Location = new System.Drawing.Point(682, 658);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(97, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.OKButton.UseVisualStyleBackColor = true;
            // 
            // RevocareButton
            // 
            this.RevocareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevocareButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevocareButton.Image = ((System.Drawing.Image)(resources.GetObject("RevocareButton.Image")));
            this.RevocareButton.Location = new System.Drawing.Point(785, 658);
            this.RevocareButton.Name = "RevocareButton";
            this.RevocareButton.Size = new System.Drawing.Size(113, 23);
            this.RevocareButton.TabIndex = 5;
            this.RevocareButton.Text = "Revocare";
            this.RevocareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.RevocareButton.UseVisualStyleBackColor = true;
            // 
            // BorderouColectareConsumButton
            // 
            this.BorderouColectareConsumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BorderouColectareConsumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderouColectareConsumButton.Image = ((System.Drawing.Image)(resources.GetObject("BorderouColectareConsumButton.Image")));
            this.BorderouColectareConsumButton.Location = new System.Drawing.Point(12, 597);
            this.BorderouColectareConsumButton.Name = "BorderouColectareConsumButton";
            this.BorderouColectareConsumButton.Size = new System.Drawing.Size(212, 39);
            this.BorderouColectareConsumButton.TabIndex = 2;
            this.BorderouColectareConsumButton.Text = "Borderou colectare consum";
            this.BorderouColectareConsumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorderouColectareConsumButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Apartament,
            this.Titular,
            this.Scara,
            this.NrPers,
            this.IndecsApaRece});
            this.dataGridView1.Location = new System.Drawing.Point(13, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 552);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Consum total inregistrat";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(785, 591);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Apartament
            // 
            this.Apartament.HeaderText = "Apartament";
            this.Apartament.Name = "Apartament";
            // 
            // Titular
            // 
            this.Titular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titular.FillWeight = 200F;
            this.Titular.HeaderText = "Titular";
            this.Titular.Name = "Titular";
            // 
            // Scara
            // 
            this.Scara.HeaderText = "Scara";
            this.Scara.Name = "Scara";
            // 
            // NrPers
            // 
            this.NrPers.HeaderText = "Nr pers";
            this.NrPers.Name = "NrPers";
            // 
            // IndecsApaRece
            // 
            this.IndecsApaRece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IndecsApaRece.FillWeight = 65F;
            this.IndecsApaRece.HeaderText = "Indecs apa rece";
            this.IndecsApaRece.Name = "IndecsApaRece";
            // 
            // DeschidereInregConsum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 693);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RevocareButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BorderouColectareConsumButton);
            this.Controls.Add(this.BorderouConsumInregistratButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "DeschidereInregConsum";
            this.Text = "Deschidere - Inregistrare consum indecsi si act nr pers in luna";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BorderouConsumInregistratButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RevocareButton;
        private System.Windows.Forms.Button BorderouColectareConsumButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apartament;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scara;
        private System.Windows.Forms.DataGridViewTextBoxColumn NrPers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndecsApaRece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
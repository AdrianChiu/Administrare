using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class AdaugareApartament : Form
    {
        public AdaugareApartament()
        {
            InitializeComponent();
        }

        private void RevocareButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Scari scari = new Scari();

            scari.Show();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class Scari : Form
    {
        public Scari()
        {
            InitializeComponent();
        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            AdaugareScara adaugareScara = new AdaugareScara();

            adaugareScara.Show();

        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DeschidereButton_Click(object sender, EventArgs e)
        {
            DeschidereScara deschidereScara = new DeschidereScara();

            deschidereScara.Show();

        }

        private void StergereButton_Click(object sender, EventArgs e)
        {
            StergereScara stergereScara = new StergereScara();

            stergereScara.Show();

        }
    }
}

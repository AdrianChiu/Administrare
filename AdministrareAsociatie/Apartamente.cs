using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class Apartamente : Form
    {
        public Apartamente()
        {
            InitializeComponent();
        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            AdaugareApartament adaugareApartament = new AdaugareApartament();

            adaugareApartament.Show();

        }

        private void DeschideButton_Click(object sender, EventArgs e)
        {
            DeschidereApartament deschidereApartament = new DeschidereApartament();

            deschidereApartament.Show();

        }

        private void StergereButton_Click(object sender, EventArgs e)
        {
            StergereApartament stergereApartament = new StergereApartament();

            stergereApartament.Show();

        }
    }
}

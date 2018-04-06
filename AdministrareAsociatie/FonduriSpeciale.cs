using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class FonduriSpeciale : Form
    {
        public FonduriSpeciale()
        {
            InitializeComponent();
        }

        private void FonduriSpeciale_Load(object sender, EventArgs e)
        {

        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            AdaugareFondSpecial adaugareFondSpecial = new AdaugareFondSpecial();

            adaugareFondSpecial.Show();

        }

        private void DeschidereButton_Click(object sender, EventArgs e)
        {
            DeschidereFondSpecial deschidereFondSpecial = new DeschidereFondSpecial();

            deschidereFondSpecial.Show();

        }

        private void StergereButton_Click(object sender, EventArgs e)
        {
            StergereFondSpecial stergereFondSpecial = new StergereFondSpecial();

            stergereFondSpecial.Show();

        }
    }
}

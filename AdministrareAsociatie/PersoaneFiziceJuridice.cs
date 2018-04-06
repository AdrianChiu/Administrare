using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class PersoaneFiziceJuridice : Form
    {
        public PersoaneFiziceJuridice()
        {
            InitializeComponent();
        }

        private void Iesirebutton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            AdaugarePersoaneFiziceJuridice adaugarePersoaneFiziceJuridice = new AdaugarePersoaneFiziceJuridice();

            adaugarePersoaneFiziceJuridice.Show();

        }

        private void DeschidereButton_Click(object sender, EventArgs e)
        {
            DeschiderePersoaneFiziceJuridice deschiderePersoaneFiziceJuridice = new DeschiderePersoaneFiziceJuridice();

            deschiderePersoaneFiziceJuridice.Show();

        }

        private void StergereButton_Click(object sender, EventArgs e)
        {
            StergerePersoaneFiziceJuridice stergerePersoaneFiziceJuridice = new StergerePersoaneFiziceJuridice();

            stergerePersoaneFiziceJuridice.Show();

        }
    }
}

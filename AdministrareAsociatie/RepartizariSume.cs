using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class RepartizariSume : Form
    {
        public RepartizariSume()
        {
            InitializeComponent();
        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdaugareRepartizarePeCriteriu a = new AdaugareRepartizarePeCriteriu();

            a.Show();
        }
    }
}

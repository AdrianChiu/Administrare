using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class StergerePersoaneFiziceJuridice : Form
    {
        public StergerePersoaneFiziceJuridice()
        {
            InitializeComponent();
        }

        private void RevocareSPButton_Click(object sender, EventArgs e) => this.Close();
    }
}

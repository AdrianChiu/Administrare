using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class DeschidereApartament : Form
    {
        public DeschidereApartament()
        {
            InitializeComponent();
        }

        private void RevocareButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

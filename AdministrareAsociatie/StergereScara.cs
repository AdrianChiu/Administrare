using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class StergereScara : Form
    {
        public StergereScara()
        {
            InitializeComponent();
        }

        private void RevocareSButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

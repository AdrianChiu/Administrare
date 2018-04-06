using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class DeschidereScara : Form
    {
        public DeschidereScara()
        {
            InitializeComponent();
        }

        private void RevocareDButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

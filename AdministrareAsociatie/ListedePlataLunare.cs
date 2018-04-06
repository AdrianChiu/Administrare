using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class ListedePlataLunare : Form
    {
        public ListedePlataLunare()
        {
            InitializeComponent();
        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DeschidereListeDePlataLunareButton_Click(object sender, EventArgs e)
        {
            DeschidereListedePlataLunare deschidereListedePlataLunare = new DeschidereListedePlataLunare();

            deschidereListedePlataLunare.Show();
            

        }

        private void ListedePlataLunare_Load(object sender, EventArgs e)
        {

        }
    }
}

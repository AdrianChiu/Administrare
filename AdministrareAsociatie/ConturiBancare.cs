using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class ConturiBancare : Form
    {
        public ConturiBancare()
        {
            //var topLeftHeaderCell = dataGridView1.TopLeftHeaderCell;
            InitializeComponent();
        }

        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            AdaugareConturiBancare adaugareConturiBancare = new AdaugareConturiBancare();

            adaugareConturiBancare.Show();

        }

        private void DeschidereButton_Click(object sender, EventArgs e)
        {
            DeschidereConturiBancare deschidereConturiBancare = new DeschidereConturiBancare();

            deschidereConturiBancare.Show();

        }

        private void StergereButton_Click(object sender, EventArgs e)
        {
            StergereConturiBancare stergereConturiBancare = new StergereConturiBancare();

            stergereConturiBancare.Show();

        }
    }
}

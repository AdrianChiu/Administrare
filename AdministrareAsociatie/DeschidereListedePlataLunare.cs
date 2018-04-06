using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class DeschidereListedePlataLunare : Form
    {
        DataTable data1, data2, data3, data4;
        Point deschidereInitialLocation;

        public DeschidereListedePlataLunare()
        {
            InitializeComponent();

            deschidereInitialLocation = DeschidereButton.Location;
            RecalculeazaButton.Hide();
            RecapitulatieButton.Hide();

            SetData();
        }

        private void SetData()
        {
            data1 = new DataTable();

            data1.Columns.Add(new DataColumn("Furnizor / fel chelt", typeof(string)));
            data1.Columns.Add(new DataColumn("Document", typeof(string)));
            data1.Columns.Add(new DataColumn("Val cu TVA", typeof(int)));
            data1.Columns.Add(new DataColumn("Val de repartizat", typeof(int)));
            data1.Columns.Add(new DataColumn("Val nerepartizata", typeof(int)));
            data1.Columns.Add(new DataColumn("Dupa nr de pers", typeof(int)));
            data1.Columns.Add(new DataColumn("Dupa cota indiviza", typeof(int)));
            data1.Columns.Add(new DataColumn("Dupa suprafata", typeof(int)));
            data1.Columns.Add(new DataColumn("Valoare", typeof(int)));
            data1.Columns.Add(new DataColumn("Cantitate", typeof(int)));
            data1.Columns.Add(new DataColumn("Val repartizata", typeof(int)));
            ColectChelSiRepartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            ColectChelSiRepartDataGridView.DataSource = data1;

            
        }
        private void ColectChelSiRepartDataGridView_Click(object sender, EventArgs e)
        {
            ColectChelSiRepartDataGridView.DataSource = data1;

        }

        private void ColectCheltsiRepartButton_Click(object sender, EventArgs e)
        {
            ColectChelSiRepartDataGridView.DataSource = data1;

            AdaugareButton.Show();
            StergereButton.Show();
            RepartizareButton.Show();
            RecapitulatieButton.Hide();
            RecalculeazaButton.Hide();

            DeschidereButton.Show();
            DeschidereButton.Location = deschidereInitialLocation;
        }

        private void TabeldeIntretinereButton_Click(object sender, EventArgs e)
        {
            data3 = new DataTable();

            data3.Columns.Add(new DataColumn("Apartament", typeof(string)));
            data3.Columns.Add(new DataColumn("Nr pers", typeof(int)));
            data3.Columns.Add(new DataColumn("Supr utila", typeof(int)));
            data3.Columns.Add(new DataColumn("Pe nr pers", typeof(int)));
            data3.Columns.Add(new DataColumn("Chelt individuale", typeof(int)));
            data3.Columns.Add(new DataColumn("Pe cota indiviza", typeof(int)));
            data3.Columns.Add(new DataColumn("Chelt intretinere", typeof(int)));
            data3.Columns.Add(new DataColumn("Fonduri", typeof(int)));
            data3.Columns.Add(new DataColumn("Penalizari", typeof(int)));
            data3.Columns.Add(new DataColumn("Total general", typeof(int)));
            ColectChelSiRepartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ColectChelSiRepartDataGridView.DataSource = data3;

            RecapitulatieButton.Show();
            RecalculeazaButton.Show();

            AdaugareButton.Hide();
            StergereButton.Hide();
            RepartizareButton.Hide();
            DeschidereButton.Hide();

            

        }

        private void ColectChelSiRepartDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AdaugareButton_Click(object sender, EventArgs e)
        {
            
        }

        private void DeschidereButton_Click(object sender, EventArgs e)
        {

        }

        private void RepartizareButton_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DeschidereListedePlataLunare_Load(object sender, EventArgs e)
        {

        }

        private void TabelDeIntretinereDetaliatButton_Click(object sender, EventArgs e)
        {
            data4 = new DataTable();

            data4.Columns.Add(new DataColumn("Apartament", typeof(string)));
            data4.Columns.Add(new DataColumn("Nume titular", typeof(string)));
            data4.Columns.Add(new DataColumn("Nr pers", typeof(int)));
            data4.Columns.Add(new DataColumn("Supr utila", typeof(int)));
            data4.Columns.Add(new DataColumn("Cota indiviza", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt apa rece", typeof(int)));
            data4.Columns.Add(new DataColumn("Alte chelt", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt total", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt repart individual", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt repart nr pers", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt repart supr utila", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt repart cota indiviza", typeof(int)));
            data4.Columns.Add(new DataColumn("Chelt repart total", typeof(int)));
            data4.Columns.Add(new DataColumn("Penaliz in luna", typeof(int)));
            data4.Columns.Add(new DataColumn("Total plata luna", typeof(int)));
            data4.Columns.Add(new DataColumn("Restante chelt intret", typeof(int)));
            data4.Columns.Add(new DataColumn("Restante fond reparatii", typeof(int)));
            data4.Columns.Add(new DataColumn("Restante fond rulment", typeof(int)));
            data4.Columns.Add(new DataColumn("Restante fond special", typeof(int)));
            data4.Columns.Add(new DataColumn("Restante penalizari", typeof(int)));
            data4.Columns.Add(new DataColumn("Total de plata", typeof(int)));
            ColectChelSiRepartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ColectChelSiRepartDataGridView.DataSource = data4;

            RecapitulatieButton.Show();
            RecalculeazaButton.Show();

            AdaugareButton.Hide();
            StergereButton.Hide();
            RepartizareButton.Hide();
            DeschidereButton.Hide();

        }

        private void PenalizariApartamButton_Click(object sender, EventArgs e)
        {
            data2 = new DataTable();

            data2.Columns.Add(new DataColumn("Apartament", typeof(int)));
            data2.Columns.Add(new DataColumn("Nume titular", typeof(string)));
            data2.Columns.Add(new DataColumn("Scara", typeof(string)));
            data2.Columns.Add(new DataColumn("Restante debit chelt", typeof(int)));
            data2.Columns.Add(new DataColumn("Restante debit fond reparatii", typeof(int)));
            data2.Columns.Add(new DataColumn("Restante debit fond rulment", typeof(int)));
            data2.Columns.Add(new DataColumn("Restante debit fonduri speciale", typeof(int)));
            data2.Columns.Add(new DataColumn("Total restante", typeof(int)));
            data2.Columns.Add(new DataColumn("Penalizari neachitate la zi", typeof(int)));
            data2.Columns.Add(new DataColumn("Penalizare in luna", typeof(int)));
            ColectChelSiRepartDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ColectChelSiRepartDataGridView.DataSource = data2;

            AdaugareButton.Hide();
            StergereButton.Hide();
            RepartizareButton.Hide();

            RecalculeazaButton.Hide();
            RecapitulatieButton.Hide();

            DeschidereButton.Show();
            DeschidereButton.Location = AdaugareButton.Location;

            

        }

        



        private void IesireButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

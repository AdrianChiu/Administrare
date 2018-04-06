using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdministrareAsociatie
{
    public partial class AdaugareRepartizarePeCriteriu : Form
    {
        DataTable data1, data2, data3, data4, data5, data6;

        String s1, s2, s3, s4, s5, s6;

        public AdaugareRepartizarePeCriteriu()
        {
            InitializeComponent();

            s1 = "Consum preluat : cant * pret unitar";
            s2 = "Nr de persoane";
            s3 = "Suprafata";
            s4 = "Cota indiviza";
            s5 = "Valoare directa";
            s6 = "Consum direct : cant * pret unitar";

            SetData();
        }

        private void SetData()
        {
            data1 = new DataTable();

            data1.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data1.Columns.Add(new DataColumn("Titular", typeof(string)));
            data1.Columns.Add(new DataColumn("Scara", typeof(string)));
            data1.Columns.Add(new DataColumn("Cantitate", typeof(int)));
            data1.Columns.Add(new DataColumn("Ok", typeof(int)));
            data1.Columns.Add(new DataColumn("Valoare", typeof(int)));

            data2 = new DataTable();

            data2.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data2.Columns.Add(new DataColumn("Titular", typeof(string)));
            data2.Columns.Add(new DataColumn("Scara", typeof(string)));
            data2.Columns.Add(new DataColumn("Nr pers", typeof(int)));
            data2.Columns.Add(new DataColumn("Ok", typeof(int)));
            data2.Columns.Add(new DataColumn("Valoare", typeof(int)));

            data3 = new DataTable();

            data3.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data3.Columns.Add(new DataColumn("Titular", typeof(string)));
            data3.Columns.Add(new DataColumn("Scara", typeof(string)));
            data3.Columns.Add(new DataColumn("Suprafata", typeof(int)));
            data3.Columns.Add(new DataColumn("Ok", typeof(int)));
            data3.Columns.Add(new DataColumn("Valoare", typeof(int)));

            data4 = new DataTable();

            data4.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data4.Columns.Add(new DataColumn("Titular", typeof(string)));
            data4.Columns.Add(new DataColumn("Scara", typeof(string)));
            data4.Columns.Add(new DataColumn("Cota indiviza", typeof(int)));
            data4.Columns.Add(new DataColumn("Ok", typeof(int)));
            data4.Columns.Add(new DataColumn("Valoare", typeof(int)));

            data5 = new DataTable();

            data5.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data5.Columns.Add(new DataColumn("Titular", typeof(string)));
            data5.Columns.Add(new DataColumn("Scara", typeof(string)));
            data5.Columns.Add(new DataColumn("valoare", typeof(int)));

            data6 = new DataTable();

            data6.Columns.Add(new DataColumn("Apart.", typeof(int)));
            data6.Columns.Add(new DataColumn("Titular", typeof(string)));
            data6.Columns.Add(new DataColumn("Scara", typeof(string)));
            data6.Columns.Add(new DataColumn("Cantitate", typeof(int)));
            data6.Columns.Add(new DataColumn("Valoare", typeof(int)));


            comboBox2.Items.AddRange(new object[] {
            s1, s2, s3, s4, s5, s6});

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem)
            {
                case "Consum preluat : cant * pret unitar":
                    dataGridView1.DataSource = data1;
                    break;
                case "Nr de persoane":
                    dataGridView1.DataSource = data2;
                    break;
                case "Suprafata":
                    dataGridView1.DataSource = data3;
                    break;
                case "Cota indiviza":
                    dataGridView1.DataSource = data4;
                    break;
                case "Valoare directa":
                    dataGridView1.DataSource = data5;
                    break;
                case "Consum direct : cant * pret unitar":
                    dataGridView1.DataSource = data6;
                    break;
            }
        }
    }
}

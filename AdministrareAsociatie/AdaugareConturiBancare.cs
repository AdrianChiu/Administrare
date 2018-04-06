using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace AdministrareAsociatie
{
    public partial class AdaugareConturiBancare : Form
    {/*
        private SqlConnection connection;
        string connectionString;
        */
        string denumire;
        string IBAN;


        public AdaugareConturiBancare()
        {
            InitializeComponent();

            //connectionString = ConfigurationManager.ConnectionStrings["AdministrareAsociatie.Properties.Settings.ConturiBancareConnectionString"].ConnectionString;
        }

        private void RevocareButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void conturiBancareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {/*
            this.Validate();
            this.conturiBancareBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.conturiBancareDataSet);
            */
        }

        private void AdaugareConturiBancare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conturiBancareDataSet.ConturiBancare' table. You can move, or remove it, as needed.
           // this.conturiBancareTableAdapter.Fill(this.conturiBancareDataSet.ConturiBancare);

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            denumire = textBox1.Text;
            IBAN = textBox2.Text;
            String str = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ady\\source\\repos\\AdministrareAsociatie\\AdministrareAsociatie\\DB\\ConturiBancare.mdf;Integrated Security=True;Connect Timeout=30";
            String query = "INSERT INTO ContBancar (Denumire, IBAN) values ('" + denumire + "','" + IBAN + "')";

            SqlConnection con = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dbr;

            try
            {
                con.Open();
                dbr = cmd.ExecuteReader();
                MessageBox.Show("saved");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

    
    }
}

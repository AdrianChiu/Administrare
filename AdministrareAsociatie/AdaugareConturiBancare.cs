using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AdministrareAsociatie
{
    public partial class AdaugareConturiBancare : Form
    {
        string denumire;
        string IBAN;


        public AdaugareConturiBancare()
        {
            InitializeComponent();
        }

        private void RevocareButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        
        private void conturiBancareBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void AdaugareConturiBancare_Load(object sender, EventArgs e)
        {

        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            denumire = textBox1.Text;
            IBAN = textBox2.Text;

            string MyConString = "SERVER=localhost;" + "DATABASE=administraredb;" + "UID=root;" + "PASSWORD=1234;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "insert into ContBancar(denumire, iban) values('" + denumire + "','" + IBAN + "') ;";
            connection.Open();
            
            Reader = command.ExecuteReader();
            /*
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";
                Console.WriteLine(thisrow);
            }*/
            connection.Close();
        }
    }
}

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
using AdministrareAsociatie.Connection;

namespace AdministrareAsociatie
{
    public partial class AdaugareConturiBancare : Form
    {
        string denumire;
        string IBAN;

        Entity entity = Entity.GetObject();
        ContBancarCon contBancarCon = new ContBancarCon();

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

            //contBancarCon.Insert(denumire, IBAN);

            ConturiBancare cont = new ConturiBancare();
            DataGridView data = cont.GetDataTable();

            DataTable d = contBancarCon.Read();
            data.DataSource = d;

            cont.SetDataTable(data);

            /*
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ",";
                Console.WriteLine(thisrow);
            }*/

            //entity.CloseConnection();
        }
    }
}

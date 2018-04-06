using AdministrareAsociatie.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AdministrareAsociatie.Connection
{
    class ContBancarCon
    {
        private Entity entity = Entity.GetObject();
        private MySqlDataReader Reader;

        public void Insert(string denumire, string IBAN)
        {
            MySqlCommand command = entity.CreateConnection();
            command.CommandText = "insert into contbancar(denumire, iban) values('" + denumire + "','" + IBAN + "') ;";

            Reader = command.ExecuteReader();

            entity.CloseConnection();
        }

        public void Update(ContBancar contBancar, string denumire, string IBAN)
        {
            MySqlCommand command = entity.CreateConnection();
            command.CommandText = "update contbancar set denumire='" + denumire + "',iban='" + IBAN + "';";

            Reader = command.ExecuteReader();

            entity.CloseConnection();
        }

        public DataTable Read()
        {
            MySqlCommand command = entity.CreateConnection();
            command.CommandText = "select * from contbancar;";

            Reader = command.ExecuteReader();

            DataTable dTable = new DataTable();
            dTable.Columns.Add("ID", typeof(string));
            dTable.Columns.Add("Denumire", typeof(string));
            dTable.Columns.Add("IBAN", typeof(string));

            dTable.Rows.Add("1", "da", "da");
            DataRow row;// = dTable.NewRow();
            //DataRow row2 = dTable.NewRow();

            while (Reader.Read())
            {
                row = dTable.NewRow();
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    thisrow += Reader.GetValue(i).ToString() + ",";
                    switch (i)
                    {
                        case 0:
                            row["ID"] = Reader.GetValue(0).ToString();
                            break;
                        case 1:
                            row["Denumire"] = Reader.GetValue(1).ToString();
                            break;
                        case 2:
                            row["IBAN"] = Reader.GetValue(2).ToString();
                            break;
                    }   
                }
                dTable.Rows.Add(row);
            }



        

            //entity.CloseConnection();

            return dTable;
        }
    }
}

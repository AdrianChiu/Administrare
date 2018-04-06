using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdministrareAsociatie.Connection
{
    class Entity
    {
        private static Entity instance;
        private readonly string MyConString = "SERVER=localhost;" + "DATABASE=administraredb;" + "UID=root;" + "PASSWORD=1234;";
        private MySqlConnection connection;

        private Entity()
        {
            
        }

        public static Entity GetObject()
        {
            if(instance is null)
            {
                instance = new Entity();
            }

            return instance;
        }

        public MySqlCommand CreateConnection()
        {
            connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();

            connection.Open();

            return command;
        }

        public void CloseConnection()
        {
            connection.Close();
        }
    }
}

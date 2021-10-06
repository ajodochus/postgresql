using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Data;

namespace UserControl_postgreSql
{

    class Npgsql_handler
    {
        Dictionary<string, string> abc;
        public NpgsqlConnection conn;

        public void connect_to_server()
        {
            string conStr = "Server=127.0.0.1; Port=5439; User Id=postgres; Database=postgres;";
            conn = new NpgsqlConnection(conStr);
            conn.Open();

        }

        public void test_sql()
        {

            string comStr = "Select * FROM \"mytable\";";
            NpgsqlCommand com = new NpgsqlCommand(comStr, conn);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write("{0} \t \n", row[i].ToString());
                }
            }
        }
    }

    
}

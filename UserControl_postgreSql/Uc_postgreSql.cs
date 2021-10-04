using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace UserControl_postgreSql
{
    public partial class Uc_postgreSql : UserControl
    {
        private static Uc_postgreSql _instance;
        static string project_name;
        static string suite_dir;
        static string sqlserverdir;

        public static Uc_postgreSql Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Uc_postgreSql();
                }
                return _instance;
            }
        }
        public Uc_postgreSql()
        {
            InitializeComponent();
            Console.WriteLine("assembly exec: " + Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("curr sqlserverdir: " + Directory.GetCurrentDirectory());
            Console.WriteLine("proj sqlserverdir.  " + Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);
            Console.WriteLine("name: " + this.GetType().Namespace);

             project_name = this.GetType().Namespace;
             suite_dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
             sqlserverdir = Path.Combine(suite_dir, project_name, "server");
        }

        public void start_sql_server()
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            p.StartInfo = info;
            p.Start();
            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                   
                   // string sqlserverdir = @"D:\\pgsql\\";
                    sw.WriteLine("cd " + sqlserverdir);
                    sw.WriteLine("@SET PATH=\""+sqlserverdir+"\\bin\";%PATH%");
                    sw.WriteLine("@SET PGDATA="+sqlserverdir+"\\data");
                    sw.WriteLine("@SET PGDATABASE=postgres");
                    sw.WriteLine("@SET PGUSER=postgres");
                    sw.WriteLine("@SET PGPORT=5439");
                    sw.WriteLine("@SET PGLOCALEDIR="+sqlserverdir+"\\share\\locale");
                    if (!Directory.Exists(Path.Combine(sqlserverdir, "data")))
                    {
                        sw.WriteLine(sqlserverdir + @"\bin\initdb -U postgres -A trust");
                    }
                    sw.WriteLine(sqlserverdir + @"\bin\pg_ctl -D "+ sqlserverdir + @"\data\ -l logfile start");
                    Console.WriteLine("env var: " + Environment.GetEnvironmentVariable("PGDATA"));

                }
            }
        }

        public void stop_sql_server()
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            p.StartInfo = info;
            p.Start();
            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine(sqlserverdir + @"\bin\pg_ctl -D " + sqlserverdir + @"\data\ stop");
                }
            }
        }

        public void test_sql()
        {
            // creating the connection string (Server, Port, User id, password, database)
            //string conStr = "Server=127.0.0.1; Port=5439; User Id=meier; Password=meier.123; Database=postgres;";
            string conStr = "Server=127.0.0.1; Port=5439; User Id=postgres; Database=postgres;";
            NpgsqlConnection conn = new NpgsqlConnection(conStr);
            string comStr = "Select * FROM \"mytable\";";
            NpgsqlCommand com = new NpgsqlCommand(comStr, conn);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            mydatagrid.DataSource = dt;
            // Not needed
            // NpgsqlDataReader dRead = com.ExecuteReader();
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    Console.Write("{0} \t \n", row[i].ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test_sql();
        }

        private void start_sqlServer_Click(object sender, EventArgs e)
        {
            start_sql_server();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop_sql_server();
        }
    }
}

﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using Npgsql;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;

namespace UserControl_postgreSql
{
    public partial class Uc_postgreSql : UserControl
    {
        private static Uc_postgreSql _instance;
        static string project_name;
        static string suite_dir;
        static string sqlserverdir;
        public NpgsqlConnection conn;




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
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            project_name = this.GetType().Namespace;
            suite_dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            sqlserverdir = Path.Combine(suite_dir, project_name, @"server\");

        }

        public void start_sql_server()
        {
            pnl_service_status.BackColor = Color.White;
            pnl_service_status.Refresh();

            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = Path.Combine("cmd.exe");
            info.RedirectStandardInput = true;
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            p.StartInfo = info;
            //p.OutputDataReceived += CaptureOutput;
            //p.ErrorDataReceived += CaptureError;
            p.Start();


            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("cd " + sqlserverdir);
                    sw.WriteLine("@SET PATH=\"" + sqlserverdir + "bin\";%PATH%");
                    sw.WriteLine("@SET PGDATA=" + sqlserverdir + "data");
                    sw.WriteLine("@SET PGDATABASE=" + tb_database.Text);
                    sw.WriteLine("@SET PGUSER=" + tb_user_id.Text);
                    sw.WriteLine("@SET PGPORT=" + tb_port.Text);
                    sw.WriteLine("@SET PGLOCALEDIR=" + sqlserverdir + "share\\locale");

                    if (!Directory.Exists(Path.Combine(sqlserverdir, "data")))
                    {
                        sw.WriteLine(sqlserverdir + @"\bin\initdb -U postgres -A trust");
                    }
                    sw.WriteLine(sqlserverdir + @"\bin\pg_ctl -D " + sqlserverdir + @"\data\ -l logfile_postgresql -N postgres register");

                    servicePostgreStart();

                    string conStr = "Server=" + tb_server.Text + "; Port=" + tb_port.Text + "; User Id=" + tb_user_id.Text + "; Database=" + tb_database.Text + ";";
                    conn = new NpgsqlConnection(conStr);

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
                    sw.WriteLine("cd " + sqlserverdir);
                    sw.WriteLine("@SET PATH=\"" + sqlserverdir + "bin\";%PATH%");
                    sw.WriteLine("@SET PGDATA=" + sqlserverdir + "data");
                    sw.WriteLine("@SET PGDATABASE=postgres");
                    sw.WriteLine("@SET PGUSER=postgres");
                    sw.WriteLine("@SET PGPORT=5439");
                    sw.WriteLine("@SET PGLOCALEDIR=" + sqlserverdir + "share\\locale");
                    sw.WriteLine(sqlserverdir + @"\bin\pg_ctl -D " + sqlserverdir + @"\data\ stop");
                }
            }





        }


        public void servicePostgreStart()
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = "postgres";
            

            if (sc.Status == ServiceControllerStatus.Stopped)
            {
                // Start the service if the current status is stopped.
                try
                {
                    // Start the service, and wait until its status is "Running".
                    sc.Start();
                    sc.WaitForStatus(ServiceControllerStatus.Running);

                    // Display the current service status.
                    pnl_service_status.Text = sc.Status.ToString();
                    pnl_service_status.BackColor = Color.Green;
                }
                catch (InvalidOperationException)
                {
                    //
                }
            }

        }

        public void servicePostgreStop()
        {
            ServiceController sc = new ServiceController();
            sc.ServiceName = "postgres";


            if (sc.Status == ServiceControllerStatus.Running)
            {
                // stop the service if the current status is running.
                try
                {
                    // Start the service, and wait until its status is "Running".
                    sc.Stop();
                    sc.WaitForStatus(ServiceControllerStatus.Stopped);

                    // Display the current service status.
                    pnl_service_status.Text = sc.Status.ToString();
                    pnl_service_status.BackColor = Color.Red;
                }
                catch (InvalidOperationException)
                {
                    //
                }
            }
        }


        static void CaptureOutput(object sender, DataReceivedEventArgs e)
        {
            ShowOutput(e.Data);
        }

        static void ShowOutput(string data)
        {
            if (data != null)
            {
                //Console.WriteLine("Received: {0}", data);
                if (data == "Server läuft")
                {
                    //
                }
            }
        }

        static void CaptureError(object sender, DataReceivedEventArgs e)
        {
            ShowOutput(e.Data);
        }



        public void test_sql()
        {

            //string comStr = tb_conn_string.Text;
            //string comStr = "Select \"ID\" FROM \"mytable\";";
            //string comStr = "Select * FROM \"mytable\";";
            string comStr = cbx_sql_string.SelectedItem.ToString();
            NpgsqlCommand com = new NpgsqlCommand(comStr, conn);
            NpgsqlDataAdapter ad = new NpgsqlDataAdapter(com);

            DataTable dt = new DataTable();
            ad.Fill(dt);
            mydatagrid.DataSource = dt;

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
            //stop_sql_server();
            servicePostgreStart();
        }



        void OnProcessExit(object sender, EventArgs e)
        {
            Console.WriteLine("I'm out of here");

            servicePostgreStop();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            test_sql();
        }

        private void btn_stop_service_Click(object sender, EventArgs e)
        {
            servicePostgreStop();
        }
    }
}

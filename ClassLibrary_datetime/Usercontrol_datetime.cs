using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Usercontrol_datetime
{
    public partial class Usercontrol_datetime : UserControl
    {
        DateTime today;
        
        private static Usercontrol_datetime _instance;
        public static Usercontrol_datetime Instance
        {

            get
            {
                if (_instance == null)
                {
                    _instance = new Usercontrol_datetime();
                }
                
                return _instance;
            }
        }
        public Usercontrol_datetime()
        {
            InitializeComponent();
            today = DateTime.Today;
            tb_date_today.Text = today.ToString("dd.MM.yyyy");
        }


        void setDate(string dateInYourSystemFormat)
        {
            var proc = new System.Diagnostics.ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C date " + dateInYourSystemFormat;
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch
            {
                MessageBox.Show("Error to change time of your system");
                Application.ExitThread();
            }
        }
        void setTime(string timeInYourSystemFormat)
        {
            var proc = new System.Diagnostics.ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C time " + timeInYourSystemFormat;
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch
            {
                MessageBox.Show("Error to change time of your system");
                Application.ExitThread();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            setDate(tb_set_date.Text);
        }
    }
}

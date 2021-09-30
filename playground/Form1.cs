using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace playground
{
    public partial class Playground : Form
    {
        public Playground()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rgb_slider_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UserControl_rgb_slider.rgb_slider.Instance))
            {
                panel.Controls.Add(UserControl_rgb_slider.rgb_slider.Instance);
                UserControl_rgb_slider.rgb_slider.Instance.Dock = DockStyle.Fill;
                UserControl_rgb_slider.rgb_slider.Instance.BringToFront();
            }
            else
            {
                UserControl_rgb_slider.rgb_slider.Instance.BringToFront();
            }
        }



        private void btn_system_datetime_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(Usercontrol_datetime.Usercontrol_datetime.Instance))
            {
                panel.Controls.Add(Usercontrol_datetime.Usercontrol_datetime.Instance);
                Usercontrol_datetime.Usercontrol_datetime.Instance.Dock = DockStyle.Fill;
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
            else
            {
                Usercontrol_datetime.Usercontrol_datetime.Instance.BringToFront();
            }
        }

        private void sqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(UserControl_postgreSql.Uc_postgreSql.Instance))
            {
                panel.Controls.Add(UserControl_postgreSql.Uc_postgreSql.Instance);
                UserControl_postgreSql.Uc_postgreSql.Instance.Dock = DockStyle.Fill;
                UserControl_postgreSql.Uc_postgreSql.Instance.BringToFront();
            }
            else
            {
                UserControl_postgreSql.Uc_postgreSql.Instance.BringToFront();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dsfgToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       
    }
}

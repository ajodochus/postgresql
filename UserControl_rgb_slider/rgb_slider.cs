using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_rgb_slider
{
    public partial class rgb_slider : UserControl
    {
        private static rgb_slider _instance;

        public static rgb_slider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new rgb_slider();
                }
                return _instance;
            }
        }




        private Color _control_color;

        public Color Control_Color
        {
            get { return _control_color; }
            set { _control_color = value; }
        }


        public rgb_slider()
        {
            InitializeComponent();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            int val_red = tb_red.Value;
            int val_green = tb_green.Value;
            int val_blue = tb_blue.Value;
            Color control_color = Color.FromArgb(val_red, val_green, val_blue);

            try
            {
                panel_color.BackColor = control_color;
                _control_color = control_color;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}

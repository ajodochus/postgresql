using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_sql_input
{
    public partial class Sql_input : UserControl
    {
        private static Sql_input _instance;

        public static Sql_input Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Sql_input();
                }
                return _instance;
            }
        }
        public Sql_input()
        {
            InitializeComponent();
        }
    }
}

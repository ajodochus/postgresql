using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_postgreSql
{
    public partial class Uc_postgreSql : UserControl
    {
        private static Uc_postgreSql _instance;

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
        }
    }
}

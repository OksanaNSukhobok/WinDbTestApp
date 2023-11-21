using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnMySQL_Click(object sender, EventArgs e)
        {
            string s = MySqlDbHelper.DoDbTest();
            MessageBox.Show(s);
        }

        private void BtnMsSql_Click(object sender, EventArgs e)
        {
            string s = MsSqlDbHelper.DoDbTest();
            MessageBox.Show(s);
        }
    }
}

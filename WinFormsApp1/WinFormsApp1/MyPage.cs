using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MyPage : Form
    {
        private Form parentform;
        public MyPage(Form parentForm)
        {
            parentform = parentForm;
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentform.Visible = true;
        }
    }
}

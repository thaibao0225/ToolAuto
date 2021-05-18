using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolAuto.Management;

namespace ToolAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OtherManagement otherManagement = new OtherManagement();

            otherManagement.test();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

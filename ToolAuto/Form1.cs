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
using ToolAuto.Model.Socical;
using ToolAuto.Management.Socical;

namespace ToolAuto
{
    public partial class Form1 : Form
    {
        UserFbModel userFbModel;
        public Form1()
        {
            InitializeComponent();
        }

        private void SetDataInput()
        {
            userFbModel = new UserFbModel();
            userFbModel.user = FacebookUserTxt.Text;
            userFbModel.password = FacebookPasswordTxt.Text;
            userFbModel.UserName = FacebookUserNameTxt.Text;
        }

        private void GetData()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OtherManagement otherManagement = new OtherManagement();

            otherManagement.test();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetDataInput();

            FacebookManagement facebookManagement = new FacebookManagement(userFbModel);
            facebookManagement.StartProfile();

        }
    }
}

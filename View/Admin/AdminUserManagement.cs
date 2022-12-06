using ASM1MVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM1MVC.View.Admin
{
    public partial class AdminUserManagement : Form
    {
        public UserController listUser = new UserController();
        public AdminUserManagement(string value)
        {
            InitializeComponent();
            lblName.Text = value;
            LoadData();
        }
        public void InitData()
        {
            listUser.clearList();
            listUser.LoadData();
        }
        public void LoadData()
        {
            InitData();
            datagvBooks.DataSource = null;
            datagvBooks.DataSource = listUser.getUser();
            //int sizeWidth = 120;
            //for (int i = 0; i < 6; i++)
            //{
            //    datagvBooks.Columns[i].Width = sizeWidth;
            //}
        }
        private void AdminUserManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Role tempRole = new Role();
            tempRole.Show();
        }

        private void datagvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminHome tempAdminHome = new AdminHome(lblName.Text);
            tempAdminHome.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace đồ_án_chuyên_đề
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.ServerName = txtServername.Text.Trim();
            Program.UserName = txtUsername.Text.Trim();
            Program.Password = txtPassword.Text.Trim();
            if (Program.Connect() == true)
            {
                FrmMain formMain = new FrmMain();
                this.Hide();
                formMain.Closed += (s, args) =>
                {
                    this.Show();
                };
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

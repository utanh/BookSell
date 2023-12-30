using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Bán_sách
{
    public partial class Profile : Form
    {
        private User user = new User();
        private string image = "";
        public Profile(User user)
        {
            InitializeComponent();

            this.user = user;

            txtAddress.Text = this.user.getAddress();
            txtMoney.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", this.user.getMoney()) + " vnđ";
            txtName.Text = this.user.getName();
            txtPhoneNum.Text = this.user.getPhoneNum();
            nudAge.Value = (decimal)this.user.getAge();
            
            if (this.user.getSex().Equals("Nam"))
                rbtnMale.Checked = true;
            else
                rbtnFemale.Checked = true;
            
            if (!this.user.avata.Equals(""))
                pictureBox1.Image = System.Drawing.Image.FromFile(this.user.avata);

            this.btnConfirm.Visible = false;
            this.txtMoneyAdd.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Title = "Open Image file";
            fileOpen.Filter = "JPG Files (*.png)| *.png";

            if (fileOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = fileOpen.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(@selectedFile);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                image = @selectedFile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.user.setMoney(int.Parse(this.txtMoney.Text.Replace(".","").Replace("vnđ", "")));
            this.user.setAddress(this.txtAddress.Text);
            this.user.setPhoneNum(this.txtPhoneNum.Text);
            this.user.setName(this.txtName.Text);
            this.user.setAge((int)this.nudAge.Value);

            if (this.rbtnMale.Checked)
                this.user.setSex("Nam");
            else
                this.user.setSex("Nữ");

            if(!image.Equals(""))
                user.avata = image;
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            btnAddMoney.Visible = false;
            btnConfirm.Visible = true;
            txtMoneyAdd.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.user.addMoney(int.Parse(txtMoneyAdd.Text));
            btnAddMoney.Visible = true;
            btnConfirm.Visible = false;
            txtMoneyAdd.Visible = false;

            txtMoney.Text = string.Format(new CultureInfo("vi-VN"), "{0:#,##0}", this.user.getMoney()) + " vnđ";
        }
    }
}

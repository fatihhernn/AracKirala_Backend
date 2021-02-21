using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmYeniKullaniciEkle : Form
    {
        private IUserService _userService;
        public FrmYeniKullaniciEkle()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _userService.Add(new User
            {
                
                FirstName = txtFirstName.Text,
                LastName=txtLastName.Text,
                Email=txtEmail.Text,
                Password=txtPassword.Text
            });
            
            MessageBox.Show(Messages.AddedUser);
            Close();
        }

        private void gbxUserInfo_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

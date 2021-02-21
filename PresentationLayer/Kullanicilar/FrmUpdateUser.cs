using Business.Abstract;
using Business.Concrete;
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
    public partial class FrmUpdateUser : Form
    {
        private IUserService _userService;


        int _id;
        
        public FrmUpdateUser(int id, string firstName, string lastName, string email, string password)
        {
            InitializeComponent();
            _id = id;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtEmail.Text = email;
            txtPassword.Text = password;
            _userService = new UserManager(new EfUserDal());
        }



        private void btnAddUser_Click(object sender, EventArgs e)
        {     
            _userService.Update(new User
            {
                Id=_id,
                FirstName=txtFirstName.Text,
                LastName=txtLastName.Text,
                Email=txtEmail.Text,
                Password=txtPassword.Text
            });
            Close();

        }

        private void FrmUpdateUser_Load(object sender, EventArgs e)
        {

        }
    }
}

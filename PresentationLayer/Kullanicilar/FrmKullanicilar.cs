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
    public partial class FrmKullanıcılar : Form
    {
        private IUserService _userService;

        public FrmKullanıcılar()
        {
            InitializeComponent();
            _userService = new UserManager(new EfUserDal());
        }

        private void User_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = _userService.GetAll().Data;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmYeniKullaniciEkle frmAddUser = new FrmYeniKullaniciEkle();
            frmAddUser.ShowDialog();
            LoadUsers();          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var row = dgvUsers.CurrentRow;
            
            int id=Convert.ToInt32(row.Cells[0].Value);
            string firstname = row.Cells[1].Value?.ToString();
            string lastname = row.Cells[2].Value?.ToString();
            string email = row.Cells[3].Value?.ToString();
            string password = row.Cells[4].Value?.ToString();

            
            FrmUpdateUser frmUpdateUser = new FrmUpdateUser(id,firstname,lastname,email,password);
           
            frmUpdateUser.ShowDialog();
            LoadUsers();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvUsers.CurrentRow != null)
                {
                    try
                    {
                        MessageBox.Show(
                                 _userService.Delete(new User
                                {
                                    Id = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)
                                }).Message
                            );
                        LoadUsers();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilmiş satır yok");
                }
            }

            
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
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

namespace PresentationLayer.Arabalar
{
    public partial class FrmMarka : Form
    {
        IBrandService _brandService;
        public FrmMarka()
        {
            InitializeComponent();
            _brandService = new BrandManager(new EfBrandDal());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(
                _brandService.Add(new Brand
                    {
                        Description = txtMarka.Text
                    }).Message
            );

            Close();
        }
    }
}

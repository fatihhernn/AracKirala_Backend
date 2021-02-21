using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Arabalar
{
    public partial class FrmRenkEkle : Form
    {
        IColorService _colorService;

        public FrmRenkEkle()
        {
            InitializeComponent();
            _colorService = new ColorManager(new EfColorDal());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                _colorService.Add(new Color
                     {
                        Description = txtRenk.Text
                      }).Message);
            Close();
        }
    }
}

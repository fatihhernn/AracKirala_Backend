using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class FrmArabaGuncelle : Form
    {
        private ICarService _carService;
        private IBrandService _brandService;
        private IColorService _colorService;

        Car _car;
            
        public FrmArabaGuncelle(Car car)
        {
            InitializeComponent();
            _car=car;
            _carService = new CarManager(new EfCarDal());
            _colorService = new ColorManager(new EfColorDal());
            _brandService = new BrandManager(new EfBrandDal());
        }

        private void btnArabaGuncelle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                   _carService.Update(new Car
                   {
                       Id = _car.Id,
                       BrandId = Convert.ToInt32(cbxModel.SelectedValue),
                       ColorId = Convert.ToInt32(cbxRenk.SelectedValue),
                       DailyPrice = Convert.ToDecimal(txtGunlukFiyat.Text),
                       Description = txtTanim.Text,
                       ModelYear = Convert.ToDateTime(txtModelYili.Text)
                   }).Message
               );
            Close();
        }

        private void FrmArabaGuncelle_Load(object sender, EventArgs e)
        {
            ArabalayiGetir();
        }

        private void ArabalayiGetir()
        {
            MarkalariDoldur();
            RenkleriDoldur();

            txtGunlukFiyat.Text = _car.DailyPrice.ToString();
            txtModelYili.Text = _car.ModelYear.ToString();
            txtTanim.Text = _car.Description.ToString();
        }

        private void RenkleriDoldur()
        {
            cbxRenk.DataSource = _colorService.GetAll().Data;
            cbxRenk.DisplayMember = "Description";
            cbxRenk.ValueMember = "Id";
        }

        private void MarkalariDoldur()
        {
            cbxModel.DataSource = _brandService.GetAll().Data;
            cbxModel.DisplayMember = "Description";
            cbxModel.ValueMember = "Id";
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Arabalar
{
    public partial class FrmArabaEkle : Form
    {
        IColorService _colorService;
        IBrandService _brandService;
        ICarService _carService;
        public FrmArabaEkle()
        {
            InitializeComponent();
            _colorService = new ColorManager(new EfColorDal());
            _brandService = new BrandManager(new EfBrandDal());
            _carService = new CarManager(new EfCarDal());
        }

        private void btnYeniArabaEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                     _carService.Add(new Car
                     {
                         BrandId = Convert.ToInt32(cbxModel.SelectedValue),
                         ColorId = Convert.ToInt32(cbxRenk.SelectedValue),
                         DailyPrice = Convert.ToDecimal(txtGunlukFiyat.Text),
                         Description = txtTanim.Text,
                         ModelYear = Convert.ToDateTime(txtModelYili.Text)
                     }).Message
                );
            Close();
        }

        private void FrmArabaEkle_Load(object sender, EventArgs e)
        {
            RenkleriGetir();
            MarkalariGetir();
        }

        private void MarkalariGetir()
        {
            cbxModel.DataSource = _brandService.GetAll().Data;
            cbxModel.DisplayMember = "Description";
            cbxModel.ValueMember = "Id";
        }

        private void RenkleriGetir()
        {
            cbxRenk.DataSource = _colorService.GetAll().Data;
            cbxRenk.DisplayMember = "Description";
            cbxRenk.ValueMember = "Id";
        }

        private void btnRenkEkle_Click(object sender, EventArgs e)
        {
            FrmRenkEkle frmRenkEkle = new FrmRenkEkle();
            frmRenkEkle.ShowDialog();
            RenkleriGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMarka frmMarka = new FrmMarka();
            frmMarka.ShowDialog();
            MarkalariGetir();
        }
    }
}

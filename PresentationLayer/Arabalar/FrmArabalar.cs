using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using PresentationLayer.Arabalar;
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
    public partial class FrmArabalar : Form
    {
        private ICarService _carService;
        
        public FrmArabalar()
        {
            InitializeComponent();
            _carService = new CarManager(new EfCarDal());
            
        }

        private void FrmArabalar_Load(object sender, EventArgs e)
        {
            GetCarDetails();
        }

        private void GetCarDetails()
        {
            dgvArabalar.DataSource = _carService.GetCarDetails().Data;
        }

        private void btnYeniArabaEkle_Click(object sender, EventArgs e)
        {
            FrmArabaEkle frmArabaEkle = new FrmArabaEkle();
            frmArabaEkle.ShowDialog();
            
        }

        private void txtArabaAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtArabaAra.Text))
            {
                GetCarDetails();
            }
            else
            {
                
            }
        }

        private void btnArabaSil_Click(object sender, EventArgs e)
        {
            if (dgvArabalar.CurrentRow != null)
            {

                if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        MessageBox.Show(
                                _carService.Delete(new Car
                                {
                                    Id = Convert.ToInt32(dgvArabalar.CurrentRow.Cells[0].Value)
                                }).Message
                            );

                        GetCarDetails();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }    
            }
            else
            {
                MessageBox.Show("Seçilmiş satır yok");
            }
        }

        private void btnArabaGuncelle_Click(object sender, EventArgs e)
        {

            int carId =(int) dgvArabalar.CurrentRow.Cells[0].Value;

            Car _car=(Car) _carService.GetById(carId).Data;

            FrmArabaGuncelle frmArabaGuncelle = new FrmArabaGuncelle(_car);
            frmArabaGuncelle.ShowDialog();
            ArabaDetaylariniGetir();

        }

        private void btnListeGuncelle_Click(object sender, EventArgs e)
        {
            ArabaDetaylariniGetir();
        }

        private void ArabaDetaylariniGetir()
        {
            dgvArabalar.DataSource = _carService.GetCarDetails().Data;
        }
    }
}

using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Kiralama
{
    public partial class FrmKiralama : Form
    {
        IRentalService _rentService;
        IUserService _userService;
        ICarService _carService;

        public FrmKiralama()
        {
            InitializeComponent();

            _rentService = new RentalManager(new EfRentalDal());
            _userService = new UserManager(new EfUserDal());
            _carService = new CarManager(new EfCarDal());

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                    _rentService.Add(new Rental
                    {
                        CarId = Convert.ToInt32(cbxAraba.SelectedValue),
                        CustomerId = Convert.ToInt32(cbxMusteri.SelectedValue),
                        RentDate = DateTime.Now,
                        ReturnDate = txtTeslimTarih.Value
                    }).Message
                );
            
        }

        private void FrmKiralama_Load(object sender, EventArgs e)
        {
            cbxMusteri.DataSource = _userService.GetAll().Data;
            cbxMusteri.DisplayMember = "FirstName";
            cbxMusteri.ValueMember = "Id";


            cbxAraba.DataSource = _carService.GetAll().Data;
            cbxAraba.DisplayMember = "Description";
            cbxAraba.ValueMember = "Id";
        }
    }
}

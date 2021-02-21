using PresentationLayer.Kiralama;
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
    public partial class FrmGirisEkrani : Form
    {
        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKullanıcılar frmUser = new FrmKullanıcılar();
            frmUser.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmArabalar frmArabalar = new FrmArabalar();
            frmArabalar.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmKiralama frmKiralama = new FrmKiralama();
            frmKiralama.ShowDialog();
           
        }
    }
}

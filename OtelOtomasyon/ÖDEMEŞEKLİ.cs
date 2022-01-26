using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon
{
    public partial class ÖDEMEŞEKLİ : Form
    {
        public ÖDEMEŞEKLİ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriKayıt mk = new MusteriKayıt();
            mk.textBox6.Text = textBox2.Text;
            this.Hide();
        }
    }
}

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
    public partial class MusteriKayıt : Form
    {
        public MusteriKayıt()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanıcıGiris kg = new KullanıcıGiris();
            kg.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriBilgileri mb = new MusteriBilgileri();
            mb.Show();
            this.Hide();
            mb.textBox1.Text = textBox1.Text;

        }

        private void MusteriKayıt_Load(object sender, EventArgs e)
        {
            textBox4.Text = dateTimePicker2.Value.ToString();
           // textBox5.Text = dateTimePicker1.Value.ToString();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="KREDİ KARTI")
            {
                ÖDEMEŞEKLİ ös = new ÖDEMEŞEKLİ();
                ös.Show();
                //this.Hide();
            }
        }
    }
}

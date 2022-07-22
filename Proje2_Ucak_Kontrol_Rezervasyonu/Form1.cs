using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2_Ucak_Kontrol_Rezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota:"+comboBox1.Text+"- "+comboBox2.Text+ " Tarih: "+dateTimePicker1.Text+" Saat: "+ maskedTextBox1.Text);
            listBox1.Items.Add("Yolcu Bilgileri ~ Ad Soyad: "+textBox1.Text+" "+textBox2.Text +" Kimlik No: "+maskedTextBox2.Text+" Telefon No: "+ maskedTextBox3.Text);
            MessageBox.Show("Yolcu Kaydı Başarıyla Yapıldı.");
        }

        private void button2_Click(object sender, EventArgs e)
        {   label10.Text = comboBox1.Text;
            comboBox1.Text=comboBox2.Text;
            comboBox2.Text = label10.Text;
            // label10.Text=comboBox2.Text;
            //comboBox2.Text=comboBox1.Text;
            //comboBox1.Text=label10.Text;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tek_mi_Çift_mi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double sayi = Convert.ToDouble(textBox1.Text);

                if (sayi % 2 == 0)
                {
                    label2.Text= ("Girilen Sayı Çifttir");
                }
                else
                {
                    label2.Text = ("Girilen Sayı Tektir");

                }
            }
            catch (FormatException)
            {

                MessageBox.Show("HATALI VERİ GİRDİNİZ !");
            }
            finally
            {
               
            }

        }
    }
}

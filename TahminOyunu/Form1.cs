using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tahmin1.Focus();
        }

        //tb leri temizleme
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tahmin1.Text = "";
            tahmin2.Text = "";
            tahmin3.Text = "";
            tahmin4.Text = "";
        }

        //tahmin tutma 
        private void button2_Click(object sender, EventArgs e)
        {
         
         #region buda başka yol
            {

                Random rast = new Random();

                int sayi = rast.Next(1, 10);  // ilk basamak sıfır olamayacağı için 1 den başlanır.

                int sayi2, sayi3, sayi4;

                int i = 0;

                while (i < 1)
                {
                    sayi2 = rast.Next(1, 10);//sayılarda 0 olmaması için hepsinde 1 den başladık
                    sayi3 = rast.Next(1, 10);
                    sayi4 = rast.Next(1, 10);

                    if (sayi != sayi2 && sayi != sayi3 && sayi != sayi4 && sayi2 != sayi3 && sayi2 != sayi4 && sayi3 != sayi4)//sayıların birbirinden farklı olduğu durumda ilgili labellara yapıştırdık.                        
                    {
                        random1.Text = sayi.ToString();//üretilen random sayıları ilgili labellere yapıştır.
                        random2.Text = sayi2.ToString();//en sonunda bu labeller görünmez olacak.            
                        random3.Text = sayi3.ToString();
                        random4.Text = sayi4.ToString(); 
                        i++;
                    }
                }
            }
            #endregion  
           
        }

        //tahmin kontrol
        private void button1_Click(object sender, EventArgs e)
        {

            if (tahmin1.Text == random1.Text)
            {
                listBox1.Items.Add("+");
            }
            if (tahmin2.Text == random2.Text)
            {
                listBox1.Items.Add("+");
            }
            if (tahmin3.Text == random3.Text)
            {
                listBox1.Items.Add("+");
            }
            if (tahmin4.Text == random4.Text)
            {
                listBox1.Items.Add("+");
            }
            if (tahmin1.Text == random1.Text && tahmin2.Text == random2.Text && tahmin3.Text == random3.Text && tahmin4.Text == random4.Text)
            {
                MessageBox.Show("Afferin lan nasıl bildin!?");
            }
            //////////////////////////////////artıların sonu

            if (tahmin1.Text != random1.Text && tahmin1.Text == random2.Text || tahmin1.Text == random3.Text || tahmin1.Text == random4.Text)
            {
                listBox1.Items.Add("-");
            }

            if (tahmin2.Text != random2.Text && tahmin2.Text == random1.Text || tahmin2.Text == random3.Text || tahmin2.Text == random4.Text)
            {
                listBox1.Items.Add("-");
            }

            if (tahmin3.Text != random3.Text && tahmin3.Text == random1.Text || tahmin3.Text == random2.Text || tahmin3.Text == random4.Text)
            {
                listBox1.Items.Add("-");
            }

            if (tahmin4.Text != random4.Text && tahmin4.Text == random1.Text || tahmin4.Text == random2.Text || tahmin4.Text == random3.Text)
            {
                listBox1.Items.Add("-");
            }





        }


    }
}

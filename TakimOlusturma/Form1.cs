using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakimOlusturma
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            if (listBox1.Items.Count % 2 == 0)
            {
                do
                {
                    string isim = listBox1.Items[rnd.Next(0, listBox1.Items.Count)].ToString();

                    if (!(listBox2.Items.Contains(isim)))
                    {
                        listBox2.Items.Add(isim);
                    }
                }
                while (listBox2.Items.Count < listBox1.Items.Count / 2);

                do
                {
                    string isim = listBox1.Items[rnd.Next(0, listBox1.Items.Count)].ToString();

                    if ((!(listBox2.Items.Contains(isim)) && (!(listBox3.Items.Contains(isim)))))
                    {
                        {
                            listBox3.Items.Add(isim);
                        }
                    }
                }

                while (listBox3.Items.Count < listBox1.Items.Count / 2);
            }
            else
            {
                MessageBox.Show("Bir kişi daha ekleyin ya da bir kişi silin.");
            }
        }


        private void Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}


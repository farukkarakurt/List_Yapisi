using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Ornek_calısma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Kerem");
            kisiler.Add("Barış Alper");
            kisiler.Add("Abdülkerim");
            kisiler.Add("Yunus");
            kisiler.Add("Berkan");

            foreach (string k in kisiler) 
            {
                listBox1.Items.Add(k);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> Fnumara = new List<int>();

            Fnumara.Add(7);
            Fnumara.Add(52);
            Fnumara.Add(42);
            Fnumara.Add(11);
            Fnumara.Add(24);
            foreach (int i in Fnumara)
            {
                listBox2.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Class1> oyuncu = new List<Class1>();
            oyuncu.Add(new Class1() 
            {
                ADI="Kerem",
                NO=7,
                MEVKI="Kanat Forvet"
            });

            foreach (Class1 P in oyuncu)
            {
                listBox3.Items.Add(P.ADI+"--"+P.NO+"--"+P.MEVKI);
            }
        }
    }
}

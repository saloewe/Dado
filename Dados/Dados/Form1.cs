using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {   Dado d;
        
        public Form1()
        { 
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += Convert.ToString(d.Lanzar()) + "\r\n" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] vector = new int[6];
            for (int i = 0; i < 100; i++)
            {
                int c = d.Lanzar();
                vector[c - 1]++;
            }
            for (int i = 0; i < 6; i++)
            {
                textBox2.Text += Convert.ToString(vector[i]) +"\r\n" ; 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] vector = new int[12];
            for (int i = 0; i < 100; i++)
            {
                int l1 = d.Lanzar();
                int l2 = d.Lanzar();
                int c = l1 + l2;
                vector[c - 1]++;
            }
            for (int i = 1; i < 12; i++)
            {
                textBox3.Text += Convert.ToString(vector[i]) + "\r\n";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             d = new Dado();
            
        }

        
    }
}

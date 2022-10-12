using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_10_2022
{
    public partial class Form1 : Form
    {
        private Class1 tele;
        int v = 0;
        int c = 0;
        public Form1()
        {
            InitializeComponent();
            tele = new Class1();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tele.accendi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tele.spegni();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int a = v + 1;
            
            
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = v-1 ;
            
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = c+1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = c - 1;
        }
    }
}

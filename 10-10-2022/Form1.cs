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
    }
}

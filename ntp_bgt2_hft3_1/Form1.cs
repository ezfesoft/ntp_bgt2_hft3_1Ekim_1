using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_bgt2_hft3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dikdortgen sekil1=new Dikdortgen("Dikdörtgen", 5, 10);
            label2.Text = sekil1.sayi1.ToString();
        }
    }
}

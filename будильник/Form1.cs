using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace будильник
{
    public partial class Form1 : Form
    {
        Timer timer01 = new Timer();
        SoundPlayer sp = new SoundPlayer("D:\\Sound_00236.wav");
        bool b = false;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            timer01.Interval = 1000;
            timer01.Tick += new EventHandler(timer01_Tick);
            timer01.Start();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
            
        }
    }
}

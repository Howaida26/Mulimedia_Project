using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multimedia
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rlc rlc = new rlc();
            rlc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            huffman rlcd = new huffman();
            rlcd.ShowDialog();

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            adabtive_hufman rlcd = new adabtive_hufman();
            rlcd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            VR vrlc = new VR();
            vrlc.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            LZW lzw = new LZW();
            lzw.ShowDialog();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SevenSeg
{
    public partial class SevenSeg : Form
    {
        public SevenSeg()
        {
            InitializeComponent();
            
            _Reset();
        }
        private void _Reset()
        {
            btn1.BackColor = Color.Black;
            btn2.BackColor = Color.Black;
            btn3.BackColor = Color.Black;
            btn4.BackColor = Color.Black;
            btn5.BackColor = Color.Black;
            btn6.BackColor = Color.Black;
            btn7.BackColor = Color.Black;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            _Reset();
            btn4.BackColor= Color.Red;
            btn7.BackColor= Color.Red;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            _Reset();
            btn4.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn3.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            _Reset();
            btn1.BackColor = Color.Red;
            btn2.BackColor = Color.Red;
            btn4.BackColor = Color.Red;
            btn5.BackColor = Color.Red;
            btn7.BackColor = Color.Red;
            btn6.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Reset();
        }
    }
}

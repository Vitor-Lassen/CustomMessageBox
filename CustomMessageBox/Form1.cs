using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox frmmsg = new MessageBox();
            //frmmsg.Show();


            //var result = 
            MessageBox.Show("oi", "teste", "sim", "não");

           /* if(result == DialogResult.Yes)         {
                label1.Text = "sim";
            }
            if (result == DialogResult.No)
            {
                label1.Text = "não";
            }*/
            
        }

        
    }
}

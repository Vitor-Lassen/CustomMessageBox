using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_DS_I_andre
{
    public partial class MessageBox : Form
    {
        public MessageBox()
        {
            InitializeComponent();
        }
        static MessageBox MsgBox; static DialogResult result = DialogResult.No;
        
        public static DialogResult Show(string Text, string Caption, string btnOK, string btnCancel)
        {
            MsgBox = new MessageBox();
            MsgBox.lblDescri.Text = Text;
            MsgBox.btnYes.Text = btnOK;
            MsgBox.BtnNo.Text = btnCancel;
            MsgBox.lblTitle.Text = Caption;
            result = DialogResult.No;
            MsgBox.ShowDialog();
            return result;
            
            
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; MsgBox.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

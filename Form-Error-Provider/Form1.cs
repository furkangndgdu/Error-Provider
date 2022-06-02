using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Error_Provider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 500;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 11 || textBox1.Text.Length < 11)
            {
                errorProvider1.SetError(textBox1, "TC Kimik NO 11 Karakter Olmalıdır!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}

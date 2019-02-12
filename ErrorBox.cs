using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовой_проект
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
            textBox1.Text = GlobalVars.NotException;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

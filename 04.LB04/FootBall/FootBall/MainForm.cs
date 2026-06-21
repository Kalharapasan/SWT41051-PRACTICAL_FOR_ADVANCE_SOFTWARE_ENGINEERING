using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootBall
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCheer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GO BOYS", " Cheering", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

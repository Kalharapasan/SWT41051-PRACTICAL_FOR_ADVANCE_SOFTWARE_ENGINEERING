using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photos
{
    public partial class LoadPhotos : Form
    {
        public LoadPhotos()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Select Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = ofd.FileName;
                PbxPhoto.Image = Image.FromFile(ofd.FileName);
                PbxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

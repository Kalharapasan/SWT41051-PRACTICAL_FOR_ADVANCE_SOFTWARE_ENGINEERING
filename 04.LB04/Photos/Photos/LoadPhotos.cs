using System.Security.Cryptography;

namespace Photos{
    public partial class LoadPhotos : Form{
        public LoadPhotos(){
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e){
            openFileDialog1.Title = "Select First Image";
            openFileDialog1.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextBox.Text = openFileDialog1.FileName;
                PbxPhoto.Image =
                    Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnLoad2_Click(object sender, EventArgs e)
        {


            openFileDialog2.Title = "Select Second Image";
            openFileDialog2.Filter =
                "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog2.ShowDialog() == DialogResult.OK){
                PbxPhoto2.Image =
                    Image.FromFile(openFileDialog2.FileName);
                TextBox2.Text = openFileDialog2.FileName;
                PbxPhoto2.Image =
                   Image.FromFile(openFileDialog2.FileName);
            }
        }
        

    }
}
   

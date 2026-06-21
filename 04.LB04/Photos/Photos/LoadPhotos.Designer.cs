namespace Photos
{
    partial class LoadPhotos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            PbxPhoto = new PictureBox();
            BtnLoad = new Button();
            TextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            PbxPhoto2 = new PictureBox();
            BtnLoad2 = new Button();
            TextBox2 = new TextBox();
            openFileDialog2 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PbxPhoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PbxPhoto2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 18);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 0;
            label1.Text = "Select a picture ";
            // 
            // PbxPhoto
            // 
            PbxPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PbxPhoto.BackColor = SystemColors.ActiveCaption;
            PbxPhoto.BorderStyle = BorderStyle.Fixed3D;
            PbxPhoto.Location = new Point(33, 191);
            PbxPhoto.MaximumSize = new Size(200, 200);
            PbxPhoto.Name = "PbxPhoto";
            PbxPhoto.Size = new Size(188, 200);
            PbxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxPhoto.TabIndex = 1;
            PbxPhoto.TabStop = false;
            // 
            // BtnLoad
            // 
            BtnLoad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLoad.Location = new Point(66, 127);
            BtnLoad.Name = "BtnLoad";
            BtnLoad.Size = new Size(90, 32);
            BtnLoad.TabIndex = 1;
            BtnLoad.Text = "&Load ";
            BtnLoad.UseVisualStyleBackColor = true;
            BtnLoad.Click += BtnLoad_Click;
            // 
            // TextBox
            // 
            TextBox.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox.Location = new Point(33, 62);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(188, 27);
            TextBox.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "OpenFileDialog";
            // 
            // PbxPhoto2
            // 
            PbxPhoto2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PbxPhoto2.BackColor = SystemColors.ActiveCaption;
            PbxPhoto2.BorderStyle = BorderStyle.Fixed3D;
            PbxPhoto2.Location = new Point(321, 191);
            PbxPhoto2.MaximumSize = new Size(200, 200);
            PbxPhoto2.Name = "PbxPhoto2";
            PbxPhoto2.Size = new Size(181, 200);
            PbxPhoto2.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxPhoto2.TabIndex = 3;
            PbxPhoto2.TabStop = false;
            // 
            // BtnLoad2
            // 
            BtnLoad2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLoad2.Location = new Point(362, 127);
            BtnLoad2.Name = "BtnLoad2";
            BtnLoad2.Size = new Size(90, 32);
            BtnLoad2.TabIndex = 2;
            BtnLoad2.Text = "Loa&d2 ";
            BtnLoad2.UseVisualStyleBackColor = true;
            BtnLoad2.Click += BtnLoad2_Click;
            // 
            // TextBox2
            // 
            TextBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextBox2.Location = new Point(314, 62);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(188, 27);
            TextBox2.TabIndex = 4;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "OpenFileDialog";
            // 
            // LoadPhotos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 403);
            Controls.Add(TextBox2);
            Controls.Add(BtnLoad2);
            Controls.Add(PbxPhoto2);
            Controls.Add(TextBox);
            Controls.Add(BtnLoad);
            Controls.Add(PbxPhoto);
            Controls.Add(label1);
            Name = "LoadPhotos";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)PbxPhoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)PbxPhoto2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox PbxPhoto;
        private Button BtnLoad;
        private TextBox TextBox;
        private OpenFileDialog openFileDialog1;
        private PictureBox PbxPhoto2;
        private Button BtnLoad2;
        private TextBox TextBox2;
        private OpenFileDialog openFileDialog2;
    }
}

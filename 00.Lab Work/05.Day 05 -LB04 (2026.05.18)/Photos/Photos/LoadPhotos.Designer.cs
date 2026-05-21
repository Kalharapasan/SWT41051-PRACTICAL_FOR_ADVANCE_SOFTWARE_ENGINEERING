namespace Photos
{
    partial class LoadPhotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.Location = new System.Drawing.Point(66, 35);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(140, 20);
            this.Label.TabIndex = 0;
            this.Label.Text = "Select a picture ";
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PbxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbxPhoto.Location = new System.Drawing.Point(70, 76);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(128, 130);
            this.PbxPhoto.TabIndex = 1;
            this.PbxPhoto.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(42, 235);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 1;
            this.BtnLoad.Text = "&Load";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(136, 237);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 20);
            this.TextBox.TabIndex = 3;
            // 
            // LoadPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 301);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.PbxPhoto);
            this.Controls.Add(this.Label);
            this.Name = "LoadPhotos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.PictureBox PbxPhoto;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.TextBox TextBox;
    }
}


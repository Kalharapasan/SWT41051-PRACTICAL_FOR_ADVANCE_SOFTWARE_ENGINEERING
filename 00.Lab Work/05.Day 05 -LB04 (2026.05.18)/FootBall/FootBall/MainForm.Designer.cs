namespace FootBall
{
    partial class MainForm
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
            this.BtnCheer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCheer
            // 
            this.BtnCheer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheer.Location = new System.Drawing.Point(152, 104);
            this.BtnCheer.Name = "BtnCheer";
            this.BtnCheer.Size = new System.Drawing.Size(116, 53);
            this.BtnCheer.TabIndex = 0;
            this.BtnCheer.Text = "Cheer!";
            this.BtnCheer.UseVisualStyleBackColor = true;
            this.BtnCheer.Click += new System.EventHandler(this.BtnCheer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 286);
            this.Controls.Add(this.BtnCheer);
            this.Name = "MainForm";
            this.Text = "SEUSL Foot Ball ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCheer;
    }
}


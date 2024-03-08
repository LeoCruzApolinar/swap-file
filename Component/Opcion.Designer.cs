namespace swap_file.Component
{
    partial class Opcion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opcion));
            pictureBoxB = new PictureBox();
            pictureBoxA = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxB
            // 
            pictureBoxB.Image = (Image)resources.GetObject("pictureBoxB.Image");
            pictureBoxB.Location = new Point(155, 30);
            pictureBoxB.Name = "pictureBoxB";
            pictureBoxB.Size = new Size(60, 60);
            pictureBoxB.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB.TabIndex = 1;
            pictureBoxB.TabStop = false;
            pictureBoxB.Click += pictureBoxB_Click;
            // 
            // pictureBoxA
            // 
            pictureBoxA.Image = (Image)resources.GetObject("pictureBoxA.Image");
            pictureBoxA.Location = new Point(20, 30);
            pictureBoxA.Name = "pictureBoxA";
            pictureBoxA.Size = new Size(60, 60);
            pictureBoxA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA.TabIndex = 2;
            pictureBoxA.TabStop = false;
            pictureBoxA.Click += pictureBoxA_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(86, 44);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Opcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBoxA);
            Controls.Add(pictureBoxB);
            Margin = new Padding(10);
            Name = "Opcion";
            Size = new Size(249, 118);
            MouseClick += Opcion_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBoxB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxA).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxB;
        private PictureBox pictureBoxA;
        private PictureBox pictureBox3;
    }
}

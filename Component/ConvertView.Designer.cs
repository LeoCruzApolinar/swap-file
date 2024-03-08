namespace swap_file.Component
{
    partial class ConvertView
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
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, -16);
            label1.Name = "label1";
            label1.Size = new Size(386, 106);
            label1.TabIndex = 0;
            label1.Text = "De .... a ....";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(637, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(401, 283);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 230, 222);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(34, 389);
            button1.Name = "button1";
            button1.Size = new Size(562, 55);
            button1.TabIndex = 3;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(637, 417);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 27);
            textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.FromArgb(123, 140, 222);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(34, 175);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(562, 208);
            panel1.TabIndex = 1;
            panel1.DragDrop += panel1_DragDrop;
            panel1.DragEnter += panel1_DragEnter;
            panel1.DragOver += panel1_DragOver;
            panel1.DoubleClick += panel1_DoubleClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(975, 417);
            button2.Name = "button2";
            button2.Size = new Size(63, 27);
            button2.TabIndex = 5;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.5F);
            label2.Location = new Point(34, 128);
            label2.Name = "label2";
            label2.Size = new Size(549, 30);
            label2.TabIndex = 6;
            label2.Text = "Arrastra el o los archivos a la zona azul o hago doble click";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.World, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 88);
            label3.Name = "label3";
            label3.Size = new Size(395, 28);
            label3.TabIndex = 0;
            label3.Text = "Doble click para seleccionar los archivos";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            label3.DoubleClick += label3_DoubleClick;
            // 
            // ConvertView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ConvertView";
            Size = new Size(1061, 463);
            Load += ConvertView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Panel panel2;
        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}

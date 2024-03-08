namespace swap_file.Pages
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            BodyPanel = new TableLayoutPanel();
            HeaderPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            MainPanel = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            Panel = new Panel();
            listBox1 = new ListBox();
            BodyPanel.SuspendLayout();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BodyPanel
            // 
            BodyPanel.ColumnCount = 1;
            BodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            BodyPanel.Controls.Add(HeaderPanel, 0, 0);
            BodyPanel.Controls.Add(panel2, 0, 1);
            BodyPanel.Controls.Add(listBox1, 0, 2);
            BodyPanel.Dock = DockStyle.Fill;
            BodyPanel.Location = new Point(0, 0);
            BodyPanel.Margin = new Padding(0);
            BodyPanel.Name = "BodyPanel";
            BodyPanel.RowCount = 3;
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 13.8483963F));
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.1516F));
            BodyPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 144F));
            BodyPanel.Size = new Size(1146, 862);
            BodyPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            HeaderPanel.ColumnCount = 2;
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            HeaderPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1022F));
            HeaderPanel.Controls.Add(pictureBox1, 1, 0);
            HeaderPanel.Dock = DockStyle.Fill;
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Margin = new Padding(0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.RowCount = 1;
            HeaderPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            HeaderPanel.Size = new Size(1146, 99);
            HeaderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(127, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(MainPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(30, 99);
            panel2.Margin = new Padding(30, 0, 30, 26);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(2);
            panel2.Size = new Size(1086, 592);
            panel2.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.ColumnCount = 1;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            MainPanel.Controls.Add(Panel, 0, 1);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(2, 2);
            MainPanel.Margin = new Padding(0);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 2;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2748642F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 83.7251358F));
            MainPanel.Size = new Size(1082, 588);
            MainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.7373276F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.26267F));
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1082, 95);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 34);
            comboBox1.Margin = new Padding(30, 34, 10, 8);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 25);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // Panel
            // 
            Panel.AccessibleName = "";
            Panel.AutoScroll = true;
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 95);
            Panel.Margin = new Padding(0);
            Panel.Name = "Panel";
            Panel.Size = new Size(1082, 493);
            Panel.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Black;
            listBox1.Dock = DockStyle.Fill;
            listBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(0, 717);
            listBox1.Margin = new Padding(0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1146, 145);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 250);
            ClientSize = new Size(1146, 862);
            Controls.Add(BodyPanel);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomePage";
            Text = "HomePage";
            BodyPanel.ResumeLayout(false);
            HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel BodyPanel;
        private TableLayoutPanel HeaderPanel;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Panel panel2;
        public Panel Panel;
        public ListBox listBox1;
    }
}
namespace swap_file.Component
{
    partial class OpcionView
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
            GridPanel = new TableLayoutPanel();
            SuspendLayout();
            // 
            // GridPanel
            // 
            GridPanel.ColumnCount = 4;
            GridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            GridPanel.Dock = DockStyle.Fill;
            GridPanel.Location = new Point(0, 0);
            GridPanel.Margin = new Padding(0);
            GridPanel.Name = "GridPanel";
            GridPanel.Padding = new Padding(10);
            GridPanel.RowCount = 3;
            GridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GridPanel.Size = new Size(1061, 463);
            GridPanel.TabIndex = 0;
            // 
            // OpcionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(GridPanel);
            Name = "OpcionView";
            Size = new Size(1061, 463);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel GridPanel;
    }
}

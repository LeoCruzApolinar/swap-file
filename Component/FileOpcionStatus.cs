using swap_file.Models;
using swap_file.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace swap_file.Component
{
    public partial class FileOpcionStatus : UserControl
    {
        private string _ruta;
        private ConvertView _convertView;

        public string Text
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public string FilePath
        {
            get { return _ruta; }
            set { _ruta = value; }
        }

        public Color BackgroundColor
        {
            get { return panel1.BackColor; }
            set { panel1.BackColor = value; }
        }


        public FileOpcionStatus(string txt, string ruta, ConvertView parentView, Color co)
        {
            InitializeComponent();
            Text = txt;
            FilePath = ruta;
            _convertView = parentView;
            BackgroundColor = co;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

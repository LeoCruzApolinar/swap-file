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
    public partial class FileOpcion : UserControl
    {
        public string A;
        private ConvertView convertView;
        public FileOpcion(string txt, string ruta, ConvertView parentView)
        {
            InitializeComponent();
            label1.Text = txt;
            A = ruta;
            convertView = parentView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ClassOpcion.RemoveElement(A);
            convertView.LoadElement();
        }
    }
}

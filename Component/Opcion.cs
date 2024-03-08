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
    public partial class Opcion : UserControl
    {
        public int A;
        public int B;
        public Opcion(ClassOpcion.OpcionComponent opcionComponent, int metodo, int opcion)
        {
            InitializeComponent();
            pictureBoxA.ImageLocation = opcionComponent.PA;
            pictureBoxB.ImageLocation = opcionComponent.PB;
            A = metodo;
            B = opcion;
        }

        void GoPage()
        {
            HomePage homePageInstance = this.FindForm() as HomePage;
            ConvertView convertView  = new ConvertView(A, B);
            homePageInstance.Panel.Controls.Clear();
            homePageInstance.Panel.Controls.Add(convertView);
        }

        private void pictureBoxA_Click(object sender, EventArgs e)
        {
            GoPage();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GoPage();
        }

        private void pictureBoxB_Click(object sender, EventArgs e)
        {
            GoPage();
        }

        private void Opcion_MouseClick(object sender, MouseEventArgs e)
        {
            GoPage();
        }
    }
}

using swap_file.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static swap_file.Models.ClassOpcion;

namespace swap_file.Component
{
    public partial class OpcionView : UserControl
    {
        public int A;
        public OpcionView(int Opcion)
        {
            InitializeComponent();
            LoadOpcion(GetComponent(Opcion));
        }

        private void LoadOpcion(List<ClassOpcion.OpcionComponent> listOpcionComponent)
        {
            GridPanel.Controls.Clear();

            for (int i = 0; i < listOpcionComponent.Count; i++)
            {
                Opcion opcion = new Opcion(listOpcionComponent[i], i, A);
                GridPanel.Controls.Add(opcion, i, 0);
            }
        }

    }
}

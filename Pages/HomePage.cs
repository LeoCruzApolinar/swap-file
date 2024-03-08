using swap_file.Component;
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

namespace swap_file.Pages
{
    public partial class HomePage : Form
    {
        Dictionary<string, int> Option = new Dictionary<string, int>()
        {
            {"PDF",0},
            {"DOC",1},
            {"PNG",2},
            {"JPG",3},
            {"TXT",4},
        };
        public HomePage()
        {
            InitializeComponent();
            ClassOpcion.control = this;
            LoadData();
        }

        private void LoadData()
        {
            foreach (var item in Option.Keys)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Panel.Controls.Clear();
            string Key = comboBox1.SelectedItem.ToString();
            OpcionView opcionView = new OpcionView(Option[Key]);
            Panel.Controls.Add(opcionView);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Obtiene el texto del elemento seleccionado
                string selectedItemText = listBox1.SelectedItem.ToString();

                // Muestra el texto en un MessageBox
                MessageBox.Show(selectedItemText, "Texto seleccionado");
            }
        }
    }
}

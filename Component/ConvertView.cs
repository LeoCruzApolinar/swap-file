using swap_file.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace swap_file.Component
{
    public partial class ConvertView : UserControl
    {
        public int A;
        public int B;
        public string Format;
        public ConvertView(int Metodo, int Opcion)
        {
            InitializeComponent();
            A = Metodo;
            B = Opcion;
            Format = ClassOpcion.Formats[Opcion];
            ClassOpcion.controlA = this;
        }

        private void ConvertView_Load(object sender, EventArgs e)
        {
            (string, string) T = ClassOpcion.GetTitle(A, B);
            label1.Text = $"De {T.Item1} a {T.Item2}";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ClassOpcion classOpcion = new ClassOpcion();
            try
            {
                if (ClassOpcion.LPath.Count != 0)
                {
                    if (!string.IsNullOrEmpty(textBox1.Text) && Directory.Exists(textBox1.Text))
                    {
                        List<string> filePaths = ClassOpcion.GetSortedPathList();
                        ClassOpcion.LPath.Clear();
                        List<Task<string>> conversionTasks = new List<Task<string>>();

                        foreach (string file in filePaths)
                        {

                            conversionTasks.Add(Task.Run(() => classOpcion.StartProcess(A, B, file, textBox1.Text)));
                        }
                        panel1.Controls.Clear();
                        panel1.Controls.Add(label3);
                        await Task.WhenAll(conversionTasks);
                        ClassOpcion.SolveErrors();
                    }
                    else
                    {
                        MessageBox.Show("La ruta es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("No hay elementos agregados");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el proceso: {ex.Message}");
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {

            string[] files = IsValidFileExtension(Format, (string[])e.Data.GetData(DataFormats.FileDrop));

            foreach (string file in files)
            {
                ClassOpcion.AddUniqueElement(file);
            }
            LoadElement();
        }

        public void LoadElement()
        {
            panel1.Controls.Clear();
            foreach (string file in ClassOpcion.GetSortedPathList())
            {
                string fileName = Path.GetFileName(file);
                FileOpcion fileOpcion = new FileOpcion(fileName, file, this);
                fileOpcion.Dock = DockStyle.Top;
                panel1.Controls.Add(fileOpcion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var fd = new FolderBrowserDialog())
            {
                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fd.SelectedPath))
                {
                    textBox1.Text = fd.SelectedPath;
                }
            }
        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in IsValidFileExtension(Format, openFileDialog.FileNames))
                    {
                        ClassOpcion.AddUniqueElement(file);
                    }
                    LoadElement();
                }
            }
        }

        public string[] IsValidFileExtension(string desiredExtension, string[] ArrPath)
        {
            List<string> lista = new List<string>(ArrPath);
            List<string> Arr = new List<string>();
            foreach (string item in lista)
            {
                string fileExtension = Path.GetExtension(item);

                if (string.Equals(fileExtension, desiredExtension, StringComparison.OrdinalIgnoreCase))
                {
                    Arr.Add(item);
                }
                else
                {
                    ClassOpcion.AddError($"El archivo {item} no pertnece a este tipo de formato para conversion {desiredExtension}");
                }
            }
            return Arr.ToArray();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in IsValidFileExtension(Format, openFileDialog.FileNames))
                    {
                        ClassOpcion.AddUniqueElement(file);
                    }
                    LoadElement();
                }
            }
        }
    }
}

using swap_file.Component;
using swap_file.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace swap_file.Models
{
    public class ClassOpcion
    {
        public static Dictionary<int, string> Formats = new Dictionary<int, string>()
                        {
                {0,".pdf"}
            };
        public class OpcionComponent
        {
            public string PA { get; set; }
            public string PB { get; set; }
            public string ColorB { get; set; }
        }

        public static List<OpcionComponent> GetComponent(int A)
        {
            List<OpcionComponent> listOpcionComponent = new List<OpcionComponent>();
            switch (A)
            {
                case 0:
                    listOpcionComponent = new List<OpcionComponent>
                    {
                        new OpcionComponent { PA = "F:\\source\\swap-file\\Assect\\PDFPic.png", PB = "F:\\source\\swap-file\\Assect\\WordPic.png", ColorB = "#000" },
                        new OpcionComponent { PA = "Assect\\PDFPic.png", PB = "Assect\\WordPic.png", ColorB = "#000" },
                        new OpcionComponent { PA = "Assect\\PDFPic.png", PB = "Assect\\WordPic.png", ColorB = "#000" },
                        new OpcionComponent { PA = "Assect\\PDFPic.png", PB = "Assect\\WordPic.png", ColorB = "#000" },
                        new OpcionComponent { PA = "Assect\\PDFPic.png", PB = "Assect\\WordPic.png", ColorB = "#000" },
                        new OpcionComponent { PA = "Assect\\PDFPic.png", PB = "Assect\\WordPic.png", ColorB = "#000" },
                    };
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;

            }
            return listOpcionComponent;
        }

        public static (string, string) GetTitle(int a, int b)
        {
            try
            {
                Dictionary<int, List<(string, string)>> Dic = new Dictionary<int, List<(string, string)>>()
                {
                    {0, new List<(string, string)>()
                         {
                             ("PDF", "DOCX")
                         }
                    }
                };

                return Dic[b][a];
            }
            catch
            {
                return ("", "");
            }
        }

        public static List<(string, DateTime)> Errors = new List<(string, DateTime)>();

        public static void AddError(string errorMessage)
        {
            // Agregar el error con su timestamp actual
            Errors.Add((errorMessage, DateTime.Now));
            // Cargar los errores
            LoadError();
        }

        public static void LoadError()
        {
            if (control is HomePage homePageInstance)
            {
                homePageInstance.listBox1.Items.Clear();
                // Agregar los errores al control de lista
                foreach (var error in Errors)
                {
                    homePageInstance.listBox1.Items.Add($"{error.Item1} - {error.Item2}");
                }
            }
        }

        public static List<string> LPath = new List<string>();

        public class ErrorClass
        {
            public string message;
            public int value;
            public int metodo;
            public int opcion;
            public string save;
        }

        public static Dictionary<string, ErrorClass> ErrorTryList = new Dictionary<string, ErrorClass>();

        public static List<string> AddUniqueElement(string path)
        {
            if (!LPath.Contains(path))
            {
                LPath.Add(path);
                Console.WriteLine($"Elemento añadido: {path}");
            }
            else
            {
                // Agregar error si el elemento ya existe
                AddError($"El elemento ya existe: {path}");
            }
            return LPath;
        }

        public static List<string> RemoveElement(string path)
        {
            if (LPath.Contains(path))
            {
                LPath.Remove(path);
                Console.WriteLine($"Elemento eliminado: {path}");
            }
            else
            {
                // Agregar error si el elemento no existe
                AddError($"El elemento no existe: {path}");
            }
            return LPath;
        }

        public static List<string> GetSortedPathList()
        {
            return LPath.OrderBy(x => x).ToList();
        }

        public static Control control;

        public static Control controlA;

        public static ConvertOpcion convertOpcion = new ConvertOpcion();

        public static Dictionary<int, List<Func<string, string, int, int, Task<string>>>> DiccionarioDeMetodos = new Dictionary<int, List<Func<string, string, int, int, Task<string>>>>()
        {
            {0, new List<Func<string, string, int, int, Task<string>>> {

                convertOpcion.ConvertirPDFaDOCXAsync,

            }}
        };

        public async Task<string> StartProcess(int Metodo, int Opcion, string File, string Save)
        {
            ClassOpcion classOpcion = new ClassOpcion();
            classOpcion.UpdateFileStatusAsync(File, 0);

            if (DiccionarioDeMetodos.ContainsKey(Metodo))
            {
                // Ejecutar la función de conversión correspondiente y devolver el resultado
                var a = await DiccionarioDeMetodos[Opcion][Metodo](Save, File, Opcion, Metodo);
                if (a == "B")
                {
                    classOpcion.UpdateFileStatusAsync(File, 0);
                    return a;
                }
                else
                {
                    classOpcion.UpdateFileStatusAsync(File, 1);
                    return a;
                }

            }
            else
            {
                throw new ArgumentException($"No se encontró una función de conversión para los valores {Metodo}, {Opcion}");
            }
        }

        public async void UpdateFileStatusAsync(string path, int Status)
        {
            if (Status == 0)
            {
                if (controlA is ConvertView convertView)
                {
                    string fileName = Path.GetFileName(path);
                    convertView.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
                    {
                        FileOpcionStatus fileOpcionStatus = new FileOpcionStatus(fileName, path, convertView, Color.Yellow);
                        fileOpcionStatus.Dock = DockStyle.Top;
                        convertView.panel2.Controls.Add(fileOpcionStatus);
                    });
                }
            }
            else if (controlA is ConvertView convertView)
            {
                string fileName = Path.GetFileName(path);
                convertView.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
                {
                    foreach (var CObj in convertView.panel2.Controls)
                    {
                        if (CObj is FileOpcionStatus fileOpcionStatus)
                        {
                            PropertyInfo filePathProperty = fileOpcionStatus.GetType().GetProperty("FilePath");
                            string filePathValue = (string)filePathProperty.GetValue(fileOpcionStatus);

                            if (filePathValue == path)
                            {
                                // Valor que deseas asignar dinámicamente a la propiedad BackgroundColor
                                Color nuevoColor;
                                if (Status == 1)
                                {
                                    nuevoColor = Color.Green;
                                }
                                else
                                {
                                    nuevoColor = Color.Red;
                                }

                                // Accede dinámicamente a la propiedad BackgroundColor utilizando reflexión
                                PropertyInfo backgroundColorProperty = fileOpcionStatus.GetType().GetProperty("BackgroundColor");
                                backgroundColorProperty.SetValue(fileOpcionStatus, nuevoColor);
                            }
                        }
                    }
                });
            }
        }

        public static void IncrementarOAgregar(string key, string message, int metodo, int opcion, string ubicacionGuardado)
        {
            if (ErrorTryList.ContainsKey(key))
            {
                // Si la clave ya existe, incrementa su valor en 1
                ErrorTryList[key].value++;
            }
            else
            {
                // Si la clave no existe, agrega la clave con un valor de 1
                ErrorTryList.Add(key, new ErrorClass { message = message, value = 1, metodo = metodo, opcion = opcion, save = ubicacionGuardado });
            }
        }

        public static async void SolveErrors()
        {
            RemoveNullEntries();
            ClassOpcion classOpcion = new ClassOpcion();
            foreach (var error in ErrorTryList)
            {
                if (error.Value.value <= 5)
                {
                    var a = await DiccionarioDeMetodos[error.Value.opcion][error.Value.metodo](error.Value.save, error.Key, error.Value.opcion, error.Value.metodo);
                    if (a != "B")
                    {
                        classOpcion.UpdateFileStatusAsync(error.Key, 1);
                        ErrorTryList.Remove(error.Key);

                    }
                }
                else
                {
                    classOpcion.UpdateFileStatusAsync(error.Key, 2);
                    AddError($"El programa ha tenido error con el archivo {error.Key}, favor verificar el mismo o probar otra vez mensaje: {error.Value.message}");
                    ErrorTryList.Remove(error.Key);
                }
            }
            if (ErrorTryList.Count != 0)
            {
                SolveErrors();
            }

        }

        public static void RemoveNullEntries()
        {
            List<string> keysToRemove = new List<string>();

            foreach (var pair in ErrorTryList)
            {
                if (pair.Value == null)
                {
                    keysToRemove.Add(pair.Key);
                }
            }

            foreach (string key in keysToRemove)
            {
                ErrorTryList.Remove(key);
            }
        }
    }
}

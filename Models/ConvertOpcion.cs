using Spire.Pdf;
using swap_file.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Resources.ResXFileRef;

namespace swap_file.Models
{
    public class ConvertOpcion
    {
        public async Task<string> ConvertirPDFaDOCXAsync(string ubicacionGuardado, string ubicacionArchivoPDF, int opcion, int metodo)
        {
            try
            {
                // Verificar si el archivo PDF existe
                if (!File.Exists(ubicacionArchivoPDF))
                {
                    ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, "El archivo PDF no existe.", metodo, opcion, ubicacionGuardado);
                    return "B";
                }

                // Obtener el nombre del archivo sin extensión
                string nombreArchivo = Path.GetFileNameWithoutExtension(ubicacionArchivoPDF);

                // Ruta para el archivo convertido
                string archivoConvertido = Path.Combine(ubicacionGuardado, $"{nombreArchivo}-converted.docx");

                using (PdfDocument doc = new PdfDocument())
                {
                    doc.LoadFromFile(ubicacionArchivoPDF);
                    doc.SaveToFile(archivoConvertido, FileFormat.DOCX);
                }

                return ubicacionArchivoPDF;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error al convertir el archivo PDF a DOCX: {ex.Message}");
                ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, ex.Message, metodo, opcion, ubicacionGuardado);
                return "B";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir el archivo PDF a DOCX: {ex.Message}");
                ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, ex.Message, metodo, opcion, ubicacionGuardado);
                return "B";
            }
        }

        public async Task<string> ConvertirPDFaTXTAsync(string ubicacionGuardado, string ubicacionArchivoPDF, int opcion, int metodo)
        {
            try
            {
                // Verificar si el archivo PDF existe
                if (!File.Exists(ubicacionArchivoPDF))
                {
                    ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, "El archivo PDF no existe.", metodo, opcion, ubicacionGuardado);
                    return "B";
                }

                // Obtener el nombre del archivo sin extensión
                string nombreArchivo = Path.GetFileNameWithoutExtension(ubicacionArchivoPDF);

                // Ruta para el archivo convertido
                string archivoConvertido = Path.Combine(ubicacionGuardado, $"{nombreArchivo}-converted.txt");

                using (PdfDocument doc = new PdfDocument())
                {
                    doc.LoadFromFile(ubicacionArchivoPDF);
                    // Convertir a texto
                    string text = doc.ExtractText();
                    // Guardar el texto en un archivo .txt
                    File.WriteAllText(archivoConvertido, text);
                }

                return ubicacionArchivoPDF;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Error al convertir el archivo PDF a TXT: {ex.Message}");
                ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, ex.Message, metodo, opcion, ubicacionGuardado);
                return "B";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al convertir el archivo PDF a TXT: {ex.Message}");
                ClassOpcion.IncrementarOAgregar(ubicacionArchivoPDF, ex.Message, metodo, opcion, ubicacionGuardado);
                return "B";
            }
        }

    }
}

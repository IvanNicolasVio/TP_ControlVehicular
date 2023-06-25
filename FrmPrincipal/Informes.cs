using BibliotecaEntidades.AdministradoresDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Clases;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace BibliotecaEntidades.Clases
{
    public static class Informes<T>
    {
        public static void GuardarJson(List<T> data) 
        {
            if (data is null)
            {
                throw new Exception();
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                string jsonData = JsonSerializer.Serialize<List<T>>(data);

                File.WriteAllText(filePath, jsonData);
            }                        
        }

        public static void GuardarCSV(List<T> data)
        {
            if (data is null)
            {
                throw new Exception();
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var datoSeleccionado in data)
                    {
                        writer.WriteLine(datoSeleccionado.ToString());
                    }
                }
            }   
        }

        public static void GuardarPDF(List<ElementosDeBitacora> elementosDeBitacora)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Crear el título centrado en negrita
                    Paragraph title = new Paragraph("BITACORA", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 10f;

                    document.Add(title);

                    // Agregar el contenido de la lista
                    foreach (ElementosDeBitacora elementos in elementosDeBitacora)
                    {
                        Paragraph paragraph = new Paragraph($"El vehiculo: {elementos.Dominio}, salio {elementos.HorarioSalida}, con {elementos.Chofer} , DNI: {elementos.DNI}, y volvio {elementos.HorarioLlegada}, |||  Kilometros anteriores {elementos.KmAnterior}, |||  Kilometros actuales {elementos.KmNuevo}");
                        document.Add(paragraph);
                    }

                    document.Close();
                }
            }
        }

        public static void GuardarLogsPDF(List<LogParaPdf> logs)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, fs);
                    document.Open();

                    // Crear el título centrado en negrita
                    Paragraph title = new Paragraph("LOGS", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.BOLD));
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 10f;

                    document.Add(title);

                    // Agregar el contenido de la lista
                    foreach (LogParaPdf elementos in logs)
                    {
                        Paragraph paragraph = new Paragraph($"{elementos.Usuario} {elementos.Metodo} {elementos.Horario}");
                        document.Add(paragraph);
                    }

                    document.Close();
                }
            }
        }
    }


}

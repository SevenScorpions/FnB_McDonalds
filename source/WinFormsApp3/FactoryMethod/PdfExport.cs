using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDemo.FactoryMethod
{
    public class PdfExport : IExporter
    {
        public void Export(DataGridView dataGridView) {
            dataGridView.AllowUserToAddRows = false;
            if (dataGridView.Rows.Count > 0)
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = "DataGridViewExportPDF";
                saveFileDialog.DefaultExt = ".pdf";
                saveFileDialog.Filter = "PDF documents (.pdf)|*.pdf";

                DialogResult result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    PdfWriter.GetInstance(pdfDoc, new FileStream(fileName, FileMode.Create));
                    pdfDoc.Open();
                    iTextSharp.text.Font font = FontFactory.GetFont("Arial", 12);
                    PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);

                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        cell.BackgroundColor = new BaseColor(240, 240, 240);
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell.Value != null)
                            {
                                pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                            }
                            else
                            {
                                pdfTable.AddCell(new Phrase("", font));
                            }
                        }
                    }

                    pdfDoc.Add(pdfTable);

                    pdfDoc.Close();

                    MessageBox.Show("Export Successful");
                }
                else
                {
                    MessageBox.Show("Export Cancelled");
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }    
        }
    }
}

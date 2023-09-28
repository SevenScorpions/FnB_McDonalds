using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogInDemo.FactoryMethod
{
    public class CsvExport : IExporter
    {
        public void Export(DataGridView dataGridView) {
            dataGridView.AllowUserToAddRows = false;
            if (dataGridView.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "DataGridViewExportCSV";
                sfd.DefaultExt = ".csv";
                sfd.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string csv = string.Empty;

                    foreach (DataGridViewColumn column in dataGridView.Columns)
                    {
                        csv += column.HeaderText + ',';
                    }
                    csv += "\r\n";

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            csv += cell.Value.ToString().Replace(",", ";") + ',';
                        }

                        csv += "\r\n";
                    }

                    File.WriteAllText(sfd.FileName, csv);
                    MessageBox.Show("Export successfully!!!");
                }
                else
                {
                    MessageBox.Show("Export cancelled!!!");
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}

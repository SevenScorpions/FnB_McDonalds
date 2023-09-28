using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.FactoryMethod
{
    public class ExporterFactory : IExporterFactory
    {

        public IExporter CreateExporter(string format) {
            if (format == "pdf")
            {
                return new PdfExport();
            }
            else if (format == "csv")
            {
                return new CsvExport();
            }
            return null;
        }
    }
}
